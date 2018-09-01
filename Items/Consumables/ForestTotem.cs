
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Caserraria.Items.Consumables
{
    public class ForestTotem : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Forest Totem");
            Tooltip.SetDefault("Summons a Forest Spirit");
        }

        public override void SetDefaults()
        {
            item.width = 22;
            item.height = 42;
            item.maxStack = 20;
            item.value = 100;
            item.rare = 1;
            item.useAnimation = 30;
            item.useTime = 30;
            item.useStyle = 4;
            item.consumable = true;
            
        }

        public override bool CanUseItem(Player player)
        {
            if (Main.dayTime && !NPC.AnyNPCs(mod.NPCType("ForestSpirit")))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override bool UseItem(Player player)
        {
            NPC.SpawnOnPlayer(player.whoAmI, mod.NPCType("ForestSpirit"));
            Main.PlaySound(SoundID.NPCDeath33, player.position);
            
            return true;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Wood, 25);
            recipe.AddIngredient(ItemID.IronBar);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}