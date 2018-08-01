using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using Caserraria.Items;

namespace Caserraria.Items.Weapons
{
    public class Cometfury : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Cometfury");
            Tooltip.SetDefault("Makes a comet fall from the sky" + Environment.NewLine + "Comet has a homing ice trail");
        }

        public override void SetDefaults()
        {
            item.damage = 54;
            item.melee = true;
            item.width = 96;
            item.height = 96;
            item.useTime = 30;
            item.useAnimation = 30;
            item.useStyle = 1;
            item.knockBack = 7.5f;
            item.value = Item.sellPrice(gold: 8);
            item.rare = 5;
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;
            item.shoot = mod.ProjectileType("Comet");
            item.shootSpeed = 13f;
        }

        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            position = Main.screenPosition;
            position.X += Main.mouseX;
            Projectile.NewProjectile(position.X, player.position.Y - 600, 0, 25f, mod.ProjectileType("Comet"), damage, knockBack, player.whoAmI);
            return false;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Frostbrand);
            recipe.AddIngredient(ItemID.Starfury);
            recipe.AddIngredient(ItemID.SoulofMight, 5);
            recipe.AddTile(TileID.LunarCraftingStation);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
