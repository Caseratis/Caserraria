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
    public class FlockoChild : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Flocko's Child");
            Tooltip.SetDefault("This is messed up");
        }
        public override void SetDefaults()
        {
            item.damage = 64;
            item.thrown = true;
            item.noUseGraphic = true;
            item.consumable = false;
            item.width = 2;
            item.height = 2;
            item.useTime = 20;
            item.useAnimation = 20;
            item.useStyle = 1;
            item.noMelee = true;
            item.knockBack = 3;
            item.value = Item.sellPrice(gold: 15);
            item.rare = 8;
            item.UseSound = SoundID.Item1;
            item.shoot = mod.ProjectileType("FlockoProj");
            item.shootSpeed = 18f;
            item.autoReuse = true;
        }

       
    }
}
