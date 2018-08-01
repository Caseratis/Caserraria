using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Caserraria.Projectiles
{
	public class ShockKnifeProj : ModProjectile
	{
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Lightning Knife");     //The English name of the projectile
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

        public override bool PreKill(int timeLeft)
        {
            Projectile.NewProjectile(projectile.Center.X, projectile.Center.Y - 100, 0, 25, mod.ProjectileType("LightningBoltProj"), projectile.damage, 0, Main.myPlayer, 0f, 0f); //Spawning a projectile
            return true;
        }
        
    }
}