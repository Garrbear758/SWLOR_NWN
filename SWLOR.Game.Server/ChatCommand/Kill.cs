﻿using System;
using NWN;
using SWLOR.Game.Server.ChatCommand.Contracts;
using SWLOR.Game.Server.Enumeration;
using SWLOR.Game.Server.GameObject;

namespace SWLOR.Game.Server.ChatCommand
{
    [CommandDetails("Kills your target.", CommandPermissionType.DM)]
    public class Kill : IChatCommand
    {
        private readonly INWScript _;

        public Kill(INWScript script)
        {
            _ = script;
        }

        public void DoAction(NWPlayer user, NWObject target, NWLocation targetLocation, params string[] args)
        {
            var damage = _.EffectDamage(99999);
            _.ApplyEffectToObject(NWScript.DURATION_TYPE_INSTANT, damage, target);
        }

        public bool RequiresTarget => true;
    }
}
