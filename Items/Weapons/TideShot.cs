using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using Caserraria.Items;

namespace Caserraria.Items.Weapons {
public class TideShot : ModItem
{
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Tide Shot");
            Tooltip.SetDefault("Converts Wooden Arrows into Tide Arrows" + Environment.NewLine + "Tide Arrows are unaffected by water");
        }

        public override void SetDefaults()
    {
        item.damage = 17;
        item.ranged = true;
        item.width = 38;
        item.height = 60;
        item.useTime = 20;
        item.useAnimation = 20;
        item.useStyle = 5;
        item.noMelee = true;
        item.knockBack = 1.5f;
        item.value = 35000;
        item.rare = 3;
        item.UseSound = SoundID.Item5;
        item.autoReuse = true;
        item.shoot = 1;
        item.shootSpeed = 10f;
        item.useAmmo = AmmoID.Arrow;
    }
	
	public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			if (type == ProjectileID.WoodenArrowFriendly)
			{
				type = mod.ProjectileType("TideArrowProj");
			}
			return true;
		}

    public override void AddRecipes()
    {
		if(Caserraria.instance.thoriumLoaded)
			{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModLoader.GetMod("ThoriumMod").ItemType("AquaiteBar"), 13);
			recipe.AddIngredient(ModLoader.GetMod("ThoriumMod").ItemType("DepthScale"), 7);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
			}
    }
}}
