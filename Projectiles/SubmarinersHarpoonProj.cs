using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Caserraria.Projectiles
{
	public class SubmarinersHarpoonProj : ModProjectile 
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Submariner's Harpoon");     //The English name of the projectile
        }

        public override void SetDefaults()
        {
            projectile.width = 18;
            projectile.height = 56;
            projectile.timeLeft = 2500000;
            projectile.penetrate = 3;
            projectile.friendly = true;
            projectile.hostile = false;
            projectile.tileCollide = true;
            projectile.ignoreWater = true;
            projectile.thrown = true;
            projectile.aiStyle = 1;
        }
    }
}