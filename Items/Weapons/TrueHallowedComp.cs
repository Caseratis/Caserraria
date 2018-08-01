using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using Caserraria.Items;

namespace Caserraria.Items.Weapons {
public class TrueHallowedComp : ModItem
{
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("True Hallowed Compound Bow");
        }

        public override void SetDefaults()
    {
        item.damage = 48;
        item.crit = 6;
        item.ranged = true;
        item.width = 38;
        item.height = 69;
        item.useTime = 12;
        item.useAnimation = 12;
        item.useStyle = 5;
        item.noMelee = true;
        item.knockBack = 4f;
        item.value = Item.sellPrice(0, 10, 0, 0);
        item.rare = 8;
        item.UseSound = SoundID.Item5;
        item.autoReuse = true;
        item.shoot = 1;
        item.shootSpeed = 15f;
        item.useAmmo = AmmoID.Arrow;
    }

    public override void AddRecipes()
    {
        if(Caserraria.instance.thoriumLoaded)
			{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "HallowedComp", 1);
			recipe.AddIngredient(ModLoader.GetMod("ThoriumMod").ItemType("BrokenHeroBow"));
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
			}
    }
}}
