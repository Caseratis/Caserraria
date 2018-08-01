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
    public class PhantomDagger : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Phantom Dagger");
            Tooltip.SetDefault("A magical returning dagger" + Environment.NewLine + "Phases through walls");
        }
        public override void SetDefaults()
        {
            item.damage = 70;
            item.magic = true;
            item.mana = 8;
            item.noUseGraphic = true;
            item.width = 10;
            item.height = 24;
            item.useTime = 7;
            item.useAnimation = 7;
            item.useStyle = 1;
            item.noMelee = true;
            item.knockBack = 4;
            item.value = Item.sellPrice(gold: 8);
            item.rare = 8;
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;
            item.shoot = mod.ProjectileType("PhantomDaggerProj");
            item.shootSpeed = 20f;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.MagicDagger);
            recipe.AddIngredient(ItemID.Ectoplasm, 5);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
