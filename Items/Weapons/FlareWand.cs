﻿
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Caserraria.Items.Weapons
{
    public class FlareWand : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Flare Wand");
            Tooltip.SetDefault("Conjure fiery blasts!");
            Item.staff[item.type] = true;
        }

        public override void SetDefaults()
        {
            item.damage = 15;
            item.magic = true;
            item.noMelee = true;
            item.mana = 8;
            item.width = 22;
            item.height = 22;
            item.useTime = 10;
            item.useAnimation = 20;
            item.reuseDelay = 20;
            item.useStyle = 5;
            item.noMelee = true; //so the item's animation doesn't do damage
            item.knockBack = 3;
            item.value = Item.buyPrice(gold: 3);
            item.rare = 1;
            item.UseSound = SoundID.Item20;
            item.autoReuse = false;
            item.shootSpeed = 10f;
            item.shoot = mod.ProjectileType("FireBall");
        }
    }
}