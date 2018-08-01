using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Caserraria.Items.Weapons
{
    public class Airstrike : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Airstrike");
        }

        public override void SetDefaults()
        {
            item.damage = 80;
            item.ranged = true;
            item.width = 48;
            item.height = 48;
            item.useTime = 60;
            item.useAnimation = 60;
            item.useStyle = 5;
            item.noMelee = true; //so the item's animation doesn't do damage
            item.knockBack = 7;
            item.value = Item.sellPrice(gold: 25);
            item.rare = 10;
            item.UseSound = SoundID.Item61;
            item.autoReuse = false;
            item.shoot = ProjectileID.RocketI; 
            item.shootSpeed = 10f;
            item.useAmmo = AmmoID.Rocket;
        }

        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            position = Main.screenPosition;
            position.X += Main.mouseX;

            int numberProjectiles = 15;
            for (int i = 0; i < numberProjectiles; i++)
            {
                Projectile.NewProjectile(position.X + (Main.rand.Next(-10, 11)), player.position.Y + Main.rand.Next(-1500, -1100), Main.rand.Next(-5, 5), 20, type, item.damage, item.knockBack, Main.myPlayer, 0f, 0f); //Spawning a projectile
            }


            return false;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.GrenadeLauncher);
            recipe.AddIngredient(ItemID.RocketLauncher);
            recipe.AddIngredient(ItemID.FragmentVortex, 5);
            recipe.AddTile(TileID.LunarCraftingStation);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }

    }
}