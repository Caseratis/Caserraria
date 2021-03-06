using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Caserraria.Projectiles
{
	public class TinSS : ModProjectile
	{
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Thrown Tin Shortsword");     //The English name of the projectile
        }

        public override void SetDefaults()
		{
			projectile.width = 10;
            projectile.height = 44;
            projectile.timeLeft = 120;
            projectile.penetrate = 1;
            projectile.friendly = true;
            projectile.hostile = false;
            projectile.tileCollide = true;
            projectile.ignoreWater = true;
            projectile.thrown = true;
            projectile.aiStyle = 1;
		}
	}
}