function finishCasting()
    print("Speed increase: " .. getEffectValue(2))
    
    local buff = Buff.new("Sadism", getEffectValue(1), BUFFTYPE_TEMPORARY, owner)
    
    buff:setMovementSpeedPercentModifier(getEffectValue(2))
    addBuff(buff)
end

function applyEffects()
end
