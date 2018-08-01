using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using Caserraria.Items;

namespace Caserraria.Items.Weapons {
public class MythrilComp : ModItem
{
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Mythril Compound Bow");
        }

        public override void SetDefaults()
    {
        item.damage = 36;
        item.ranged = true;
        item.width = 24;
        item.height = 42;
        item.useTime = 23;
        item.useAnimation = 23;
        item.useStyle = 5;
        item.noMelee = true;
        item.knockBack = 2f;
        item.value = 90000;
        item.rare = 4;
        item.UseSound = SoundID.Item5;
        item.autoReuse = true;
        item.shoot = 1;
        item.shootSpeed = 9.5f;
        item.useAmmo = AmmoID.Arrow;
    }

    public override void AddRecipes()
    {
        ModRecipe recipe = new ModRecipe(mod);
        recipe.AddIngredient(ItemID.MythrilBar, 10);
        recipe.AddTile(TileID.MythrilAnvil);
        recipe.SetResult(this);
        recipe.AddRecipe();
    }
}}
