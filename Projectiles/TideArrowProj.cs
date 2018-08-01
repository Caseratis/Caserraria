using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Caserraria.Projectiles
{
	public class TideArrowProj : ModProjectile 
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Tide Arrow");     //The English name of the projectile
        }

        public override void SetDefaults()
        {
            projectile.width = 18;
            projectile.height = 32;
            projectile.timeLeft = 2500000;
            projectile.penetrate = 1;
            projectile.friendly = true;
            projectile.hostile = false;
            projectile.tileCollide = true;
            projectile.ignoreWater = true;
            projectile.ranged = true;
            projectile.aiStyle = 1;
			projectile.arrow = true;
			aiType = ProjectileID.WoodenArrowFriendly;
        }
    }
}