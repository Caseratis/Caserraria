
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Caserraria.Items
{
    public class ForestTreasureBag : ModItem
    {
        int Choice;
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Treasure Bag");
            Tooltip.SetDefault("{$CommonItemTooltip.RightClickToOpen}");
        }

        public override void SetDefaults()
        {
            item.maxStack = 999;
            item.consumable = true;
            item.width = 24;
            item.height = 24;
            item.rare = 1;
            item.expert = true;
            bossBagNPC = mod.NPCType("Forest Spirit");
        }

        public override bool CanRightClick()
        {
            return true;
        }

        public override void RightClick(Player player)
        {
            Choice = Main.rand.Next(0, 3);
            if (Choice == 0)
            {
                player.QuickSpawnItem(mod.ItemType("ForestBow"), 1);
            }
            if (Choice == 1)
            {
                player.QuickSpawnItem(mod.ItemType("ForestStaff"), 1);
            }
            if (Choice == 2)
            {
                player.QuickSpawnItem(mod.ItemType("ForestAxeWeapon"), 1);
            }
            player.QuickSpawnItem(mod.ItemType("WoodCharm"), 1);
        }
        
        
    }
}