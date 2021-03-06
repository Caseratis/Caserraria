﻿using Terraria.ID;
using Terraria.ModLoader;
using Terraria;

namespace Caserraria.Mounts

{
    public class SpecterScythe : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Grind quickly along surfaces!");
        }

        public override void SetDefaults()
        {
            item.width = 100;
            item.height = 26;
            item.useTime = 20;
            item.useAnimation = 20;
            item.useStyle = 1;
            item.value = Item.buyPrice(gold: 30);
            item.rare = 5;
            item.UseSound = SoundID.Item79;
            item.noMelee = true;
            item.mountType = mod.MountType("Scythe");
            
        }
    }
}