using Microsoft.Xna.Framework;
using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Caserraria.Items.Weapons
{
    public class Gatlidart : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Gatlidart");
            Tooltip.SetDefault("Fires darts at a rapid rate" + Environment.NewLine + "20% Chance to not consume ammo");
        }

        public override void SetDefaults()
        {
            item.damage = 30;
            item.ranged = true;
            item.width = 40;
            item.height = 20;
            item.useTime = 10;
            item.useAnimation = 10;
            item.useStyle = 5;
            item.noMelee = true; //so the item's animation doesn't do damage
            item.knockBack = 1;
            item.value = Item.sellPrice(gold: 10);
            item.rare = 5;
            item.UseSound = SoundID.Item11;
            item.autoReuse = true;
            item.shoot = 10; //idk why but all the guns in the vanilla source have this
            item.shootSpeed = 10f;
            item.useAmmo = AmmoID.Dart;
        }

        public override bool ConsumeAmmo(Player player)
        {
            return Main.rand.NextFloat() >= .20f;
        }

        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(10));
            speedX = perturbedSpeed.X;
            speedY = perturbedSpeed.Y;
            return true;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Gatligator);
            recipe.AddIngredient(ItemID.DartRifle);
            recipe.AddIngredient(ItemID.Blowgun);
            recipe.AddIngredient(ItemID.SoulofSight, 5);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(this);
            recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Gatligator);
            recipe.AddIngredient(ItemID.DartPistol);
            recipe.AddIngredient(ItemID.Blowgun);
            recipe.AddIngredient(ItemID.SoulofSight, 5);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}