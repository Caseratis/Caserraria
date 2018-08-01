using System;
using Caserraria.Projectiles;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace Caserraria.Items.Weapons
{
    public class ThunderboltSpear : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Lightning Bolt Spear");
            Tooltip.SetDefault("Unleashes small lightning bolts");
        }

        public override void SetDefaults()
        {
            item.damage = 14;
            item.useStyle = 5;
            item.useAnimation = 18;
            item.useTime = 24;
            item.shootSpeed = 3.7f;
            item.knockBack = 3.5f;
            item.width = 32;
            item.height = 34;
            item.scale = 1f;
            item.rare = 5;
            item.value = Item.sellPrice(gold: 5);

            item.melee = true;
            item.noMelee = true; // Important because the spear is actually a projectile instead of an item. This prevents the melee hitbox of this item.
            item.noUseGraphic = true; // Important, it's kind of wired if people see two spears at one time. This prevents the melee animation of this item.
            item.autoReuse = true; // Most spears don't autoReuse, but it's possible when used in conjunction with CanUseItem()

            item.UseSound = SoundID.Item1;
            item.shoot = mod.ProjectileType<ThunderboltSpearProj>();
        }

        public override bool CanUseItem(Player player)
        {
            // Ensures no more than one spear can be thrown out, use this when using autoReuse
            return player.ownedProjectileCounts[item.shoot] < 1;
        }

        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            int numberProjectiles = 3;
            for (int i = 0; i < numberProjectiles; i++)
            {
                Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(30)); // 30 degree spread.
                                                                                                                // If you want to randomize the speed to stagger the projectiles
                float scale = 1f - (Main.rand.NextFloat() * .5f);
                perturbedSpeed = perturbedSpeed * scale; 
                Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, mod.ProjectileType("ThunderboltProj"), damage, knockBack, player.whoAmI);
            }
            return true;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Spear);
            recipe.AddIngredient(ItemID.SunplateBlock, 5);
            recipe.AddIngredient(ItemID.Cloud, 10);
            recipe.AddIngredient(ItemID.RainCloud, 5);
            recipe.AddIngredient(ItemID.Feather, 3);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}