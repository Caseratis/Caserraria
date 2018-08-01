using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace Caserraria.Items.Weapons
{
    public class YinYangKnife : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Dao's Point");
            Tooltip.SetDefault("Throw unlimited balanced knives" + Environment.NewLine + "Can inflict confused" + Environment.NewLine + "'Find your inner pieces'");
        }

        public override void SetDefaults()
        {
            item.damage = 31;
            item.thrown = true;
            item.noUseGraphic = true;
            item.width = 2;
            item.height = 2;
            item.useTime = 8;
            item.useAnimation = 8;
            item.useStyle = 1;
            item.noMelee = true;
            item.knockBack = 1;
            item.value = 140000;
            item.rare = 5;
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;
            item.shoot = mod.ProjectileType("YinYangKnifeProj");
            item.shootSpeed = 18f;
        }

        public override void OnHitNPC(Player player, NPC target, int damage, float knockback, bool crit)
        {
            target.AddBuff(BuffID.Confused, 240);
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.DarkShard);
            recipe.AddIngredient(ItemID.LightShard);
            recipe.AddIngredient(ItemID.SoulofLight, 7);
            recipe.AddIngredient(ItemID.SoulofNight, 7);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
