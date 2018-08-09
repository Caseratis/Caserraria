using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Caserraria.Projectiles
{
    public class VortexDiscProj : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Vortex Disc");     //The English name of the projectile
        }
        private bool Home = false;
        private int Timer = 0;
        public override void SetDefaults()
        {
            projectile.width = 32;
            projectile.height = 32;
            projectile.timeLeft = 450;
            projectile.penetrate = 15;
            projectile.friendly = true;
            projectile.hostile = false;
            projectile.tileCollide = false;
            projectile.ignoreWater = true;
            projectile.thrown = true;
            projectile.aiStyle = 0;
            projectile.usesLocalNPCImmunity = true;
            projectile.localNPCHitCooldown = 10;
        }
        public override void AI()
        {
            projectile.rotation += 0.1f;
                if (Home)
                {
                Vector2 toPlayer = Main.player[projectile.owner].Center - projectile.Center;
                if (toPlayer.Length() < 32f)
                {
                    Home = false;
                }
                projectile.velocity = projectile.velocity * 0.999f + toPlayer * 0.001f;
                if (projectile.velocity.Length() > 16f)
                {
                    projectile.velocity.Normalize();
                    projectile.velocity *= 16f;
                }
                }
                else
            {
                Timer++;
                if (Timer >= 20)
                {
                    Home = true;
                    Timer = 0;
                }
            }
            
        }
    }
}