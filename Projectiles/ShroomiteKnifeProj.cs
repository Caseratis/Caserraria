using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Caserraria.Projectiles
{
	public class ShroomiteKnifeProj : ModProjectile
	{
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Toxic Sporetip");     //The English name of the projectile
        }

        public override void SetDefaults()
		{
			projectile.width = 18;
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
			target.AddBuff(BuffID.Venom, 480);
		}
	}
}