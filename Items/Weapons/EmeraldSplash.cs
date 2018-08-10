
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Caserraria.Items.Weapons
{
    public class EmeraldSplash : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Emerald Splash");
            Tooltip.SetDefault("20-meter radius EMERALD SPLASH");
        }

        public override void SetDefaults()
        {
            item.damage = 25;
            item.magic = true;
            item.noMelee = true;
            item.mana = 5;
            item.width = 84;
            item.height = 112;
            item.useTime = 8;
            item.useAnimation = 8;
            item.useStyle = 5;
            item.noMelee = true; //so the item's animation doesn't do damage
            item.knockBack = 3;
            item.value = Item.sellPrice(gold: 5);
            item.rare = 4;
            item.UseSound = SoundID.Item21;
            item.autoReuse = true;
            item.shootSpeed = 12f;
            item.alpha = 0;
            item.shoot = mod.ProjectileType("EmeraldSplashProj");
        }

        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {

                Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(15)); // 15 degree spread.
                                                                                                                // If you want to randomize the speed to stagger the projectiles
                                                                                                                // float scale = 1f - (Main.rand.NextFloat() * .3f);
                                                                                                                // perturbedSpeed = perturbedSpeed * scale; 
                Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockBack, player.whoAmI);
            
            return false; // return false because we don't want tmodloader to shoot projectile
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.WaterBolt);
            recipe.AddIngredient(ItemID.Emerald, 3);
            recipe.AddIngredient(ItemID.SoulofLight, 5);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}