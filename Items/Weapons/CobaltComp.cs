using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using Caserraria.Items;

namespace Caserraria.Items.Weapons {
public class CobaltComp : ModItem
{
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Colbalt Compound Bow");
        }

        public override void SetDefaults()
    {
        item.damage = 32;
        item.ranged = true;
        item.width = 24;
        item.height = 42;
        item.useTime = 25;
        item.useAnimation = 25;
        item.useStyle = 5;
        item.noMelee = true;
        item.knockBack = 1.5f;
        item.value = 60000;
        item.rare = 4;
        item.UseSound = SoundID.Item5;
        item.autoReuse = true;
        item.shoot = 1;
        item.shootSpeed = 9f;
        item.useAmmo = AmmoID.Arrow;
    }

    public override void AddRecipes()
    {
        ModRecipe recipe = new ModRecipe(mod);
        recipe.AddIngredient(ItemID.CobaltBar, 10);
        recipe.AddTile(TileID.Anvils);
        recipe.SetResult(this);
        recipe.AddRecipe();
    }
}}
