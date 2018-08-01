
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Caserraria.Items.Weapons
{
    public class StaffofAgni : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Staff of Agni");
            Tooltip.SetDefault("Rains down hell from above");
            Item.staff[item.type] = true;
        }

        public override void SetDefaults()
        {
            item.damage = 80;
            item.magic = true;
            item.noMelee = true;
            item.mana = 20;
            item.width = 84;
            item.height = 112;
            item.useTime = 3;
            item.useAnimation = 9;
            item.useStyle = 5;
            item.noMelee = true; //so the item's animation doesn't do damage
            item.knockBack = 3;
            item.value = Item.sellPrice(gold: 10);
            item.rare = 10;
            item.UseSound = SoundID.Item20;
            item.autoReuse = true;
            item.shootSpeed = 20f;
            item.alpha = 0;
            item.shoot = ProjectileID.InfernoFriendlyBolt;
        }

        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            position = Main.screenPosition;
            position.X += Main.mouseX;
            Projectile.NewProjectile(position.X + (Main.rand.Next(-50, 50)), player.position.Y - 600, Main.rand.Next((int)-item.shootSpeed/3, (int)item.shootSpeed/3), item.shootSpeed, ProjectileID.InfernoFriendlyBolt, damage, knockBack, player.whoAmI);
            return false;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.InfernoFork);
            recipe.AddIngredient(ItemID.MeteorStaff);
            recipe.AddIngredient(ItemID.FragmentSolar, 5);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}