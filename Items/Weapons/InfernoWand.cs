
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Caserraria.Items.Weapons
{
    public class InfernoWand : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Wand of Flames");
            Tooltip.SetDefault("Melt your enemies");
        }

        public override void SetDefaults()
        {
            item.damage = 20;
            item.magic = true;
            item.noMelee = true;
            item.mana = 15;
            item.width = 26;
            item.height = 28;
            item.useTime = 25;
            item.useAnimation = 25;
            item.useStyle = 1;
            item.noMelee = true; //so the item's animation doesn't do damage
            item.knockBack = 3;
            item.value = Item.sellPrice(gold: 2);
            item.rare = 3;
            item.UseSound = SoundID.Item20;
            item.autoReuse = true;
            item.shootSpeed = 10f;
            item.alpha = 0;
            item.shoot = mod.ProjectileType("InfernoProj");
        }

        

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.WandofSparking);
            recipe.AddIngredient(ItemID.HellstoneBar, 5);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}