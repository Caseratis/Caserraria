using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using Caserraria.Items;

namespace Caserraria.Items.Weapons {
public class OrichalcumComp : ModItem
{
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Orichalcum Compound Bow");
        }

        public override void SetDefaults()
    {
        item.damage = 38;
        item.ranged = true;
        item.width = 24;
        item.height = 42;
        item.useTime = 22;
        item.useAnimation = 22;
        item.useStyle = 5;
        item.noMelee = true;
        item.knockBack = 2f;
        item.value = 110000;
        item.rare = 4;
        item.UseSound = SoundID.Item5;
        item.autoReuse = true;
        item.shoot = 1;
        item.shootSpeed = 9.75f;
        item.useAmmo = AmmoID.Arrow;
    }

    public override void AddRecipes()
    {
        ModRecipe recipe = new ModRecipe(mod);
        recipe.AddIngredient(ItemID.OrichalcumBar, 12);
        recipe.AddTile(TileID.MythrilAnvil);
        recipe.SetResult(this);
        recipe.AddRecipe();
    }
}}
