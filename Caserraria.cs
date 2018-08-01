using System;
using Terraria.ID;
using Terraria.ModLoader;

namespace Caserraria
{
	class Caserraria : Mod
	{
        internal bool thoriumLoaded;
        internal bool calamityLoaded;
        internal bool cosmeticvarietyLoaded;
        internal bool tremorLoaded;
        static internal Caserraria instance;
        public Caserraria()
		{
			Properties = new ModProperties()
			{
				Autoload = true,
				AutoloadGores = true,
				AutoloadSounds = true
			};
		}

        public override void PostSetupContent()
        {
            
            Mod LootBags = ModLoader.GetMod("LootBags");
            if (LootBags != null)
            {
                LootBags.Call(.0, ItemType("Unknownparts"), 1, 1, 6);
                LootBags.Call(.0, ItemType("KnightmetalBar"), 10, 30, 3);
            }


            try
            {
                thoriumLoaded = ModLoader.GetMod("ThoriumMod") != null;
                calamityLoaded = ModLoader.GetMod("CalamityMod") != null;
                cosmeticvarietyLoaded = ModLoader.GetMod("CosmeticVariety") != null;
                tremorLoaded = ModLoader.GetMod("Tremor") != null;
            }
            catch (Exception e)
            {
                ErrorLogger.Log("Caserraria PostSetupContent Error: " + e.StackTrace + e.Message);
            }

        Mod bossChecklist = ModLoader.GetMod("BossChecklist");
            if (bossChecklist != null)
            {
                // To include a description:
                bossChecklist.Call("AddBossWithInfo", "Forest Spirit", 1.1f, (Func<bool>)(() => MyWorld.downedForestSpirit), "Use [i:" + ItemType("ForestTotem") + "] during the day");
            }

            
        }

        public override void Load()
        {
            instance = this;

        }

        public override void AddRecipes()
        {
            if (Caserraria.instance.thoriumLoaded)
            {
                ModRecipe recipe = new ModRecipe(this);
                recipe.AddIngredient(null, "TrueHallowedComp", 1);
                recipe.AddIngredient(ModLoader.GetMod("ThoriumMod").ItemType("TrueHemmorage"));
                recipe.AddTile(TileID.MythrilAnvil);
                recipe.SetResult(ModLoader.GetMod("ThoriumMod").ItemType("TerraBow"));
                recipe.AddRecipe();
                recipe = new ModRecipe(this);
                recipe.AddIngredient(null, "TrueHallowedComp", 1);
                recipe.AddIngredient(ModLoader.GetMod("ThoriumMod").ItemType("TrueEternalNight"));
                recipe.AddTile(TileID.MythrilAnvil);
                recipe.SetResult(ModLoader.GetMod("ThoriumMod").ItemType("TerraBow"));
                recipe.AddRecipe();
                recipe = new ModRecipe(this);
                recipe.AddIngredient(null, "HallowedComp", 1);
                recipe.AddIngredient(ModLoader.GetMod("ThoriumMod").ItemType("StrangePlating"), 12);
                recipe.AddIngredient(ItemID.HallowedBar, 4);
                recipe.AddIngredient(ItemID.SoulofMight, 5);
                recipe.AddTile(ModLoader.GetMod("ThoriumMod").TileType("SoulForge"));
                recipe.SetResult(ModLoader.GetMod("ThoriumMod").ItemType("DestroyersRage"));
                recipe.AddRecipe();
                if (Caserraria.instance.calamityLoaded)
                {
                    recipe = new ModRecipe(this);
                    recipe.AddIngredient(ModLoader.GetMod("ThoriumMod").ItemType("TrueBloodThirster"));
                    recipe.AddIngredient(ItemID.TrueExcalibur, 1);
                    recipe.AddTile(TileID.MythrilAnvil);
                    recipe.SetResult(ModLoader.GetMod("CalamityMod").ItemType("TerraEdge"));
                    recipe.AddRecipe();
                    recipe = new ModRecipe(this);
                    recipe.AddIngredient(ModLoader.GetMod("CalamityMod").ItemType("TrueCausticEdge"));
                    recipe.AddIngredient(ModLoader.GetMod("ThoriumMod").ItemType("TrueBloodThirster"));
                    recipe.AddIngredient(ItemID.FlaskofVenom, 5);
                    recipe.AddIngredient(ItemID.FlaskofCursedFlames, 5);
                    recipe.AddIngredient(ItemID.ChlorophyteBar, 15);
                    recipe.AddTile(TileID.DemonAltar);
                    recipe.SetResult(ModLoader.GetMod("CalamityMod").ItemType("TyrantYharimsUltisword"));
                    recipe.AddRecipe();
                    recipe = new ModRecipe(this);
                    recipe.AddIngredient(ModLoader.GetMod("CalamityMod").ItemType("TrueCausticEdge"));
                    recipe.AddIngredient(ModLoader.GetMod("ThoriumMod").ItemType("TrueBloodThirster"));
                    recipe.AddIngredient(ItemID.FlaskofVenom, 5);
                    recipe.AddIngredient(ItemID.FlaskofIchor, 5);
                    recipe.AddIngredient(ItemID.ChlorophyteBar, 15);
                    recipe.AddTile(TileID.DemonAltar);
                    recipe.SetResult(ModLoader.GetMod("CalamityMod").ItemType("TyrantYharimsUltisword"));
                    recipe.AddRecipe();
                    if (Caserraria.instance.tremorLoaded)
                    {
                        recipe = new ModRecipe(this);
                        recipe.AddIngredient(ModLoader.GetMod("Tremor").ItemType("TrueBloodCarnage"));
                        recipe.AddIngredient(ItemID.TrueExcalibur, 1);
                        recipe.AddTile(TileID.MythrilAnvil);
                        recipe.SetResult(ModLoader.GetMod("CalamityMod").ItemType("TerraEdge"));
                        recipe.AddRecipe();
                        recipe = new ModRecipe(this);
                        recipe.AddIngredient(ModLoader.GetMod("CalamityMod").ItemType("TrueCausticEdge"));
                        recipe.AddIngredient(ModLoader.GetMod("Tremor").ItemType("TrueBloodCarnage"));
                        recipe.AddIngredient(ItemID.FlaskofVenom, 5);
                        recipe.AddIngredient(ItemID.FlaskofCursedFlames, 5);
                        recipe.AddIngredient(ItemID.ChlorophyteBar, 15);
                        recipe.AddTile(TileID.DemonAltar);
                        recipe.SetResult(ModLoader.GetMod("CalamityMod").ItemType("TyrantYharimsUltisword"));
                        recipe.AddRecipe();
                        recipe = new ModRecipe(this);
                        recipe.AddIngredient(ModLoader.GetMod("CalamityMod").ItemType("TrueCausticEdge"));
                        recipe.AddIngredient(ModLoader.GetMod("Tremor").ItemType("TrueBloodCarnage"));
                        recipe.AddIngredient(ItemID.FlaskofVenom, 5);
                        recipe.AddIngredient(ItemID.FlaskofIchor, 5);
                        recipe.AddIngredient(ItemID.ChlorophyteBar, 15);
                        recipe.AddTile(TileID.DemonAltar);
                        recipe.SetResult(ModLoader.GetMod("CalamityMod").ItemType("TyrantYharimsUltisword"));
                        recipe.AddRecipe();
                    }
                }
            }
        }
    }
}
