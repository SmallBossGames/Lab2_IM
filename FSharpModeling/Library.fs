namespace FSharpModeling

open System

module InputConst=
    let minDelay = 4.0
    let maxDelay = 12.0
    let criticalValKoeff = 0.2
    let aNeed = 50.0
    let bNeed = 100.0

module Allocations =
    let random = new Random()

    let getCompletion ()=
        let probability = [|0.4; 0.3; 0.2; 0.1 |]
        let replenishment = [|0.1; 0.2; 0.5; 1.0 |]

        let rec findCompletion (r, pos) = 
            if(r < replenishment.[pos]) 
            then probability.[pos] 
            else findCompletion(r-replenishment.[pos], pos+1) 
        
        findCompletion(random.NextDouble(), 0)
        

module MainSystem =
    type SimulationInput = 
        {
            levelsA:double[]
            levelsB:double[]
            delaysA:double[]
            delaysB:double[]
            alphaA:double
            alphaB:double
            deltaTime:double
        }

    let delay (dMin, dMax, dCur, level, alpha)= 
        let dMid = (dMin+dMax)/2.0
        dMin+dMid*(level/dCur)+alpha*dMax
    
    let flow (level, dCur)= 
        level/dCur

    let flowInput (levelCur, criticalValue)=
        if levelCur < criticalValue 
        then Allocations.getCompletion()
        else 0.0

    let level (levelCur, dT, flowTo, flowFrom)=
        levelCur + dT * (flowTo - flowFrom)

    let levelInput(levelCur, levelDefault, fromFlow, criticalValue, dT)=
        let completion = flowInput(levelCur, criticalValue*levelDefault)
        levelCur + completion - dT*fromFlow

    let levelEnd(levelCur, dT, flowTo)=
        levelCur + dT*flowTo


    let makeProducts (levelA, levelB, aNeed, bNeed, count)=
        let rec makeProduct (levelA, levelB, count)=
            if (levelA < aNeed) || (levelB < bNeed)
            then (levelA, levelB, count)
            else makeProduct(levelA - aNeed, levelB - bNeed, count+1)
        makeProduct(levelA, levelB, count)

    let nextStatus (simInput, defaultA, defaultB, productCount)=
        let newDelays(delays:double[], levels:double[], alpha) =
            for i in 0..delays.Length-1 do
                delays.[i] <- delay (InputConst.minDelay, InputConst.maxDelay, delays.[i], levels.[i], alpha)
            delays  
        let newLevels (levels:double[], delays:double[], defaultStack) =
            for i in 0..levels.Length-1 do
                if i=0 then 
                    let flowFrom = flow(levels.[i], delays.[i])
                    levels.[i] <- levelInput(levels.[i], defaultStack, flowFrom, InputConst.criticalValKoeff, simInput.deltaTime)
                else if i=levels.Length-1 then
                    let flowTo = flow(levels.[i-1], delays.[i-1])
                    levels.[i] <- levelEnd(levels.[i], simInput.deltaTime, flowTo)
                else 
                    let flowFrom = flow(levels.[i], delays.[i])
                    let flowTo = flow(levels.[i-1], delays.[i-1])
                    levels.[i] <- level(levels.[i], simInput.deltaTime, flowTo, flowFrom)
            levels
        let newDelaysA = newDelays(simInput.delaysA, simInput.levelsA, simInput.alphaA)
        let newDelaysB = newDelays(simInput.delaysB, simInput.levelsB, simInput.alphaB)
        let newLevelsA = newLevels(simInput.levelsA, newDelaysA, defaultA) 
        let newLevelsB = newLevels(simInput.levelsB, newDelaysB, defaultB) 
        let (stackA, stackB, count) = 
            makeProducts(newLevelsA.[newLevelsA.Length-1], newLevelsB.[newLevelsB.Length-1], InputConst.aNeed, InputConst.bNeed, productCount)
        newLevelsA.[newLevelsA.Length-1] <- stackA
        newLevelsB.[newLevelsB.Length-1] <- stackB
        struct (newLevelsA, newLevelsB, count)

    let simulation(simInput, interval)=
        let defaultA = simInput.levelsA.[0]
        let defaultB = simInput.levelsB.[0]
        let rec simulateEnum (productCount, i) = 
            seq{
                let struct (levelsA, levelsB, count) =
                    nextStatus(simInput, defaultA, defaultB, productCount)
                let simTime = simInput.deltaTime*(double)i
                yield struct (simTime, count, (int)levelsA.[levelsA.Length-1], (int)levelsB.[levelsB.Length-1])
                
                if simTime < interval
                then yield! simulateEnum(count, i+1)
            }
        simulateEnum(0, 0)
        
        

