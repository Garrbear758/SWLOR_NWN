using SWLOR.Game.Server;
using SWLOR.Game.Server.Event.Conversation.Quest.AdvanceQuest;
using static SWLOR.Game.Server.NWN._;

// ReSharper disable once CheckNamespace
namespace NWN.Scripts
{
#pragma warning disable IDE1006 // Naming Styles
    public class next_state_3
#pragma warning restore IDE1006 // Naming Styles
    {
        public static int Main()
        {
            return QuestAdvance.Check(3) ? 1 : 0;
        }
    }
}
