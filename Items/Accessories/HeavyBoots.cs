using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using Caserraria.Items;

namespace Caserraria.Items.Accessories
{
	public class HeavyBoots : ModItem
	{
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Ironclad Stompers");
            Tooltip.SetDefault("10% Decreased movement speed" + Environment.NewLine + "Prevents the desert winds from pushing you around" + Environment.NewLine + "Makes you fall quicker");
        }

        public override void SetDefaults()
		{
			item.width = 22;
			item.height = 20;
			item.defense = 3;
			item.value = 12500;
			item.rare = 1;
			item.accessory = true;
		}
		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.moveSpeed -= 0.10f;
			player.buffImmune[194] = true;
            player.maxFallSpeed *= 5f;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Vertebrae, 10);
			recipe.AddIngredient(ItemID.IronBar, 10);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.RottenChunk, 10);
			recipe.AddIngredient(ItemID.IronBar, 10);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Vertebrae, 10);
			recipe.AddIngredient(ItemID.LeadBar, 10);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.RottenChunk, 10);
			recipe.AddIngredient(ItemID.LeadBar, 10);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}