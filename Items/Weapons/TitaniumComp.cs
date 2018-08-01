using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using Caserraria.Items;

namespace Caserraria.Items.Weapons {
public class TitaniumComp : ModItem
{
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Titanium Compound Bow");
        }

        public override void SetDefaults()
    {
        item.damage = 41;
        item.ranged = true;
        item.width = 24;
        item.height = 42;
        item.useTime = 19;
        item.useAnimation = 19;
        item.useStyle = 5;
        item.noMelee = true;
        item.knockBack = 2.5f;
        item.value = 140000;
        item.rare = 4;
        item.UseSound = SoundID.Item5;
        item.autoReuse = true;
        item.shoot = 1;
        item.shootSpeed = 10.5f;
        item.useAmmo = AmmoID.Arrow;
    }

    public override void AddRecipes()
    {
        ModRecipe recipe = new ModRecipe(mod);
        recipe.AddIngredient(ItemID.TitaniumBar, 12);
        recipe.AddTile(TileID.MythrilAnvil);
        recipe.SetResult(this);
        recipe.AddRecipe();
    }
}}
