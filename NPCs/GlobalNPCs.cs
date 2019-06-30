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
        public override bool InstancePerEntity
        {
            get
            {
                return true;
            }
        }

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

            if (npc.type == NPCID.Pumpking && Main.rand.Next(0, 5) == 0)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("SpecterScythe"));
            }

            if (npc.type == NPCID.MoonLordCore && Main.rand.Next(0, 5) == 0)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("TrueDiscoball"));
            }
        }

        public override void EditSpawnRate(Player player, ref int spawnRate, ref int maxSpawns)
        {
            MyPlayer p = player.GetModPlayer<MyPlayer>();
            if (p.hoardCalled)
            {
                spawnRate /= 100;
                maxSpawns *= 100;
            }

        }

    }
}