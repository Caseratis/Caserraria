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
    public class VortexDisc : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Vortex Disc");
            Tooltip.SetDefault("Throws vortex discs that surround you");
        }
        public override void SetDefaults()
        {
            item.damage = 70;
            item.thrown = true;
            item.noUseGraphic = true;
            item.width = 2;
            item.height = 2;
            item.useTime = 15;
            item.useAnimation = 9;
            item.useStyle = 1;
            item.noMelee = true;
            item.knockBack = 1;
            item.value = 10000;
            item.rare = 10;
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;
            item.shoot = mod.ProjectileType("VortexDiscProj");
            item.shootSpeed = 14f;
        }

        public override void OnHitNPC(Player player, NPC target, int damage, float knockback, bool crit)
        {
            target.AddBuff(BuffID.OnFire, 180);
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.LightDisc, 5);
            recipe.AddIngredient(ItemID.FragmentVortex, 10);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
