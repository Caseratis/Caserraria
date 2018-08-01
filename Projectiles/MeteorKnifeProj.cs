using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Caserraria.Projectiles
{
	public class MeteorKnifeProj : ModProjectile
	{
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Meteoric Shiv");     //The English name of the projectile
        }

        public override void SetDefaults()
		{
			projectile.width = 8;
            projectile.height = 28;
            projectile.timeLeft = 12000;
            projectile.penetrate = 1;
            projectile.friendly = true;
            projectile.hostile = false;
            projectile.tileCollide = true;
            projectile.ignoreWater = true;
            projectile.thrown = true;
            projectile.aiStyle = 2;
		}
		public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
	    {
			target.AddBuff(BuffID.OnFire, 60);
		}
	}
}