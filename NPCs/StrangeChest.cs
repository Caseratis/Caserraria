using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Linq;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Utilities;

namespace Caserraria.NPCs
{
    public class StrangeChest : ModNPC
    {
        public bool Chester = false;


        public override void SetStaticDefaults()
        {
            if(Chester)
            {
                DisplayName.SetDefault("Chester");

            }
            else
            {
                DisplayName.SetDefault("Strange Chest");
            }

            
        }

        public override void SetDefaults()
        {
            npc.friendly = true;
            npc.width = 52;
            npc.height = 46;
            npc.aiStyle = 0;
            npc.damage = 0;
            npc.defense = 15;
            npc.lifeMax = 250;
            npc.HitSound = SoundID.NPCHit1;
            npc.DeathSound = SoundID.NPCDeath1;
            npc.knockBackResist = 1f;
            npc.dontTakeDamageFromHostiles = true;
            npc.npcSlots = 1;
            npc.rarity = 2;
            Main.npcFrameCount[npc.type] = 2;
        }

        public override void FindFrame(int frameHeight)
        {
            if (Chester)
            {
                npc.frame.Y = 46;

            }
        }

        public override bool CanChat()
        {
            return true;
        }

        public override string GetChat()
        {
            Chester = true;
            switch (Main.rand.Next(3))
            {
                case 0:
                    return "In the Village or out in the fields, I have all the deals! You're not gonna BELIEVE what I just found in this chest. Want to see?";
                case 1:
                    return "Psst... Hey, you wouldn't BELIEVE the merchandise I've got for ya today... Why not have a look?";
                default:
                    return "Psst... Hey. I'm loaded with deals that'll blow you away! Why not have a look?";
            }

        }

        public override void SetChatButtons(ref string button, ref string button2)
        {
            button = "Yes";
        }

        public override void OnChatButtonClicked(bool firstButton, ref bool shop)
        {
            shop = true;

        }

        public override void SetupShop(Chest shop, ref int nextSlot)
        {
            shop.item[nextSlot].SetDefaults(mod.ItemType("ShovelBlade"));
            nextSlot++;
            shop.item[nextSlot].SetDefaults(mod.ItemType("FlareWand"));
            nextSlot++;
            if (NPC.downedBoss1)
            {
                shop.item[nextSlot].SetDefaults(mod.ItemType("ChaosSphere"));
                nextSlot++;
            }
            if (NPC.downedBoss2)
            {
                shop.item[nextSlot].SetDefaults(mod.ItemType("AlchemyCoin"));
                nextSlot++;
            }
            if (NPC.downedBoss3)
            {
                shop.item[nextSlot].SetDefaults(mod.ItemType("PropellerDagger"));
                nextSlot++;
                shop.item[nextSlot].SetDefaults(mod.ItemType("ThrowingAnchor"));
                nextSlot++;
                shop.item[nextSlot].SetDefaults(mod.ItemType("DustKnuckles"));
                nextSlot++;
            }
            if (Main.hardMode)
            {
                shop.item[nextSlot].SetDefaults(mod.ItemType("WarHorn"));
                nextSlot++;
            }
            if (NPC.downedMechBoss3)
            {
                shop.item[nextSlot].SetDefaults(mod.ItemType("SpecterScythe"));
                nextSlot++;
            }
            if (NPC.downedGolemBoss)
            {
                shop.item[nextSlot].SetDefaults(mod.ItemType("OrnatePlate"));
                nextSlot++;
            }

        }

        public override float SpawnChance(NPCSpawnInfo spawnInfo)
        {
            return (spawnInfo.player.ZoneRockLayerHeight ? 0.08f : 0f);
        }

        
    }
}