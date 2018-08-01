using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Caserraria.Projectiles
{
	public class YinYangKnifeProj : ModProjectile
	{
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Balanced Knife");     //The English name of the projectile
        }

        public override void SetDefaults()
		{
			projectile.width = 10;
            projectile.height = 26;
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
			target.AddBuff(BuffID.Confused, 240);
		}
	}
}