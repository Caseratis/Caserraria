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
	public class BoomSaw : ModItem
	{
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Boomsaw");
            Tooltip.SetDefault("Lobs a grenade with each swing" + Environment.NewLine + "'Yo dawg we heard you like swords, saws and grenade launchers'");
        }

        public override void SetDefaults()
		{
			item.damage = 240;
			item.melee = true;
			item.width = 72;
			item.height = 78;
			item.useTime = 12;
			item.useAnimation = 12;
			item.useStyle = 1;
			item.knockBack = 2;
			item.value = 35000000;
			item.rare = 4;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.shoot = 30;
			item.shootSpeed = 13f;
			item.expert = true;
		}
		
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.LunarBar, 30);
			
			if(Caserraria.instance.thoriumLoaded)
			{
			recipe.AddIngredient(ModLoader.GetMod("ThoriumMod").ItemType("TerrariumCore"), 10);
			}
			
			if(Caserraria.instance.calamityLoaded)
			{
			recipe.AddIngredient(ModLoader.GetMod("CalamityMod").ItemType("MeldiateBar"), 10);
			}
			
			if(Caserraria.instance.cosmeticvarietyLoaded)
			{
			recipe.AddIngredient(ModLoader.GetMod("CosmeticVariety").ItemType("Pallasite"), 30);
			}
			
			recipe.AddIngredient(null, "Unknownparts", 1);
			recipe.AddTile(TileID.LunarCraftingStation);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
