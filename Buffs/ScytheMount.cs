﻿using Terraria;
using Terraria.ModLoader;

namespace Caserraria.Buffs
{
    public class ScytheMount : ModBuff
    {
        public override void SetDefaults()
        {
            DisplayName.SetDefault("Scythe");
            Description.SetDefault("Grind on surfaces!");
            Main.buffNoTimeDisplay[Type] = true;
            Main.buffNoSave[Type] = true;
        }

        public override void Update(Player player, ref int buffIndex)
        {
            player.mount.SetMount(mod.MountType<Mounts.Scythe>(), player);
            player.buffTime[buffIndex] = 10;
        }
    }
}