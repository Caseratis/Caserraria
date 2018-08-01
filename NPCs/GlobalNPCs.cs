using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using System;

namespace Caserraria.NPCs
{
    public class GlobalNPCs : GlobalNPC
    {

        public override void NPCLoot(NPC npc)
        {
            if (npc.type == NPCID.Flocko && Main.rand.Next(0, 15) == 0)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("FlockoChild"));
            }

            if (npc.type == NPCID.HeadlessHorseman && Main.rand.Next(0, 15) == 0)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("JackoLantern"));
            }
        }
    }
}