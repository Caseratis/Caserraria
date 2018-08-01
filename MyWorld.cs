
using System.Collections.Generic;
using System.IO;
using Terraria;
using Terraria.ModLoader;
using Terraria.ModLoader.IO;

namespace Caserraria
{
    public class MyWorld : ModWorld
    {
        public static bool downedForestSpirit = false;
        public static bool downedDarkSlime = false;
        public static bool downedHardGoblinArmy = false;

        public override void Initialize()
        {
            downedForestSpirit = false;
            downedDarkSlime = false;
            downedHardGoblinArmy = false;
            
        }

        public override TagCompound Save()
        {
            var downed = new List<string>();

            if (downedForestSpirit) downed.Add("ForestSpirit");
            if (downedDarkSlime) downed.Add("DarkSlime");
 

            return new TagCompound {
                {"downed", downed},
            };
        }

        public override void Load(TagCompound tag)
        {
            var downed = tag.GetList<string>("downed");
            downedForestSpirit = downed.Contains("ForestSpirit");
            downedDarkSlime = downed.Contains("DarkSlime");
        }

        public override void NetSend(BinaryWriter writer)
        {
            BitsByte flags = new BitsByte();
            flags[0] = downedForestSpirit;
            flags[0] = downedDarkSlime;
            flags[0] = downedHardGoblinArmy;
            writer.Write(flags);

        }

        public override void NetReceive(BinaryReader reader)
        {
            BitsByte flags = new BitsByte();
            downedForestSpirit = flags[0];
            downedDarkSlime = flags[0];
            downedHardGoblinArmy = flags[0];
        }
    }
}
