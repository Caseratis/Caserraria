using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Caserraria.Projectiles
{
	public class SolarKnifeProj : ModProjectile
	{
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Solar Knife");     //The English name of the projectile
        }

        public override void SetDefaults()
		{
			projectile.width = 22;
            projectile.height = 36;
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
			target.AddBuff(BuffID.Daybreak, 300);
            Projectile.NewProjectile(target.position.X, target.position.Y, 0, 0, ProjectileID.SolarWhipSwordExplosion, damage, 0, Main.myPlayer);
        }
	}
}