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
    public class JackoLantern : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Spoopy Lantern");
            Tooltip.SetDefault("Pretty L I T");
        }
        public override void SetDefaults()
        {
            item.damage = 40;
            item.thrown = true;
            item.noUseGraphic = true;
            item.consumable = false;
            item.width = 2;
            item.height = 2;
            item.useTime = 20;
            item.useAnimation = 20;
            item.useStyle = 1;
            item.noMelee = true;
            item.knockBack = 5;
            item.value = Item.sellPrice(gold: 12);
            item.rare = 8;
            item.UseSound = SoundID.Item1;
            item.shoot = mod.ProjectileType("JackoLanternProj");
            item.shootSpeed = 15f;
            item.autoReuse = true;
        }


    }
}
