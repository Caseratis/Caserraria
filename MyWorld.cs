
using System.Collections.Generic;
using System.IO;
using Terraria;
using Terraria.GameContent.Generation;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ModLoader.IO;
using Terraria.World.Generation;

namespace Caserraria
{
    public class MyWorld : ModWorld
    {
        public static bool downedForestSpirit = false;


        public override void Initialize()
        {
            downedForestSpirit = false;


        }

        public override TagCompound Save()
        {
            var downed = new List<string>();

            if (downedForestSpirit) downed.Add("ForestSpirit");



            return new TagCompound {
                {"downed", downed},
            };
        }

        public override void Load(TagCompound tag)
        {
            var downed = tag.GetList<string>("downed");
            downedForestSpirit = downed.Contains("ForestSpirit");

        }

        public override void NetSend(BinaryWriter writer)
        {
            BitsByte flags = new BitsByte();
            flags[0] = downedForestSpirit;

            writer.Write(flags);

        }

        public override void NetReceive(BinaryReader reader)
        {
            BitsByte flags = new BitsByte();
            downedForestSpirit = flags[0];

        }
    }
}
