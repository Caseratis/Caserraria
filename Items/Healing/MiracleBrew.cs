using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using Caserraria.Items;

namespace Caserraria.Items.Healing
{
	public class MiracleBrew : ModItem
	{
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Miracle Brew");
            Tooltip.SetDefault("When super healing potions just aren't enough..." + Environment.NewLine + "Stacks up to 10 instead of the usual 30" + Environment.NewLine + "Expensive to craft in bulk and is 3x heavier then a standard potion, but heals a ton");
        }
        public override void SetDefaults()
		{
			item.useStyle = 2;
			item.useTime = 17;
			item.useAnimation = 17;
			item.UseSound = SoundID.Item3;
			item.value = 250000;
			item.rare = 11;
			item.healLife = 500;
			item.maxStack = 10;
			item.consumable = true;
			item.potion = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "StalwartPotion", 3);
			recipe.AddIngredient(ItemID.LunarOre, 8);
			recipe.AddIngredient(ItemID.FragmentVortex, 8);
			recipe.AddIngredient(ItemID.FragmentSolar, 8);
			recipe.AddIngredient(ItemID.FragmentStardust, 8);
			recipe.AddIngredient(ItemID.FragmentNebula, 8);
			
			if(Caserraria.instance.thoriumLoaded)
			{
			recipe.AddIngredient(ModLoader.GetMod("ThoriumMod").ItemType("DeathEssence"), 2);
			recipe.AddIngredient(ModLoader.GetMod("ThoriumMod").ItemType("OceanEssence"), 2);
			recipe.AddIngredient(ModLoader.GetMod("ThoriumMod").ItemType("InfernoEssence"), 2);
			}
			
			recipe.AddTile(TileID.Bottles);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}