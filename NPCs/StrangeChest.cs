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
        public override bool Autoload(ref string name)
        {
            name = "Strange Chest";
            return mod.Properties.Autoload;
        }

        public override string Texture
        {
            get
            {
                return "Caserraria/NPCs/StrangeChest";
            }
        }


        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Strange Chest");
        }

        public override void SetDefaults()
        {
            npc.friendly = true;
            npc.width = 32;
            npc.height = 28;
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
        }

        public override bool CanChat()
        {
            return true;
        }

        public override string GetChat()
        {

            return "...";

        }

        public override void SetChatButtons(ref string button, ref string button2)
        {
            button = "Have a look at items";
        }

        public override void OnChatButtonClicked(bool firstButton, ref bool shop)
        {
            shop = true;


        }

        public override void SetupShop(Chest shop, ref int nextSlot)
        {
            shop.item[nextSlot].SetDefaults(mod.ItemType("FlareWand"));
            nextSlot++;
            if (NPC.downedBoss3)
            {
                shop.item[nextSlot].SetDefaults(mod.ItemType("DustKnuckles"));
                nextSlot++;
            }

        }

        public override float SpawnChance(NPCSpawnInfo spawnInfo)
        {
            return (spawnInfo.player.ZoneRockLayerHeight ? 0.08f : 0f);
        }
    }
}