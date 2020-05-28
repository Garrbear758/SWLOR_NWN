﻿using SWLOR.Game.Server.Enumeration;
using SWLOR.Game.Server.NWN.Enum;

namespace SWLOR.Game.Server.ValueObject
{
    public class AIPerkDetails
    {
        public int FeatID { get; set; }
        public PerkExecutionType ExecutionType { get; set; }

        public AIPerkDetails(int featID, PerkExecutionType executionType)
        {
            FeatID = featID;
            ExecutionType = executionType;
        }
    }
}
