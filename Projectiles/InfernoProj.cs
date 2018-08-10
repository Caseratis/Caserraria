using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Caserraria.Projectiles
{
    public class InfernoProj : ModProjectile
    {
        private int timer = 0;
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Inferno");     //The English name of the projectile
        }

        public override void SetDefaults()
        {
            projectile.magic = true;
            projectile.width = 30;
            projectile.height = 30;
            projectile.friendly = true;
            projectile.penetrate = 5;
            projectile.timeLeft = 45;
            projectile.tileCollide = true;
            projectile.alpha = 255;
        }

        public override void AI()
        {
            for (int k = 0; k < 15; k++)
            {

                Dust dust;
                // You need to set position depending on what you are doing. You may need to subtract width/2 and height/2 as well to center the spawn rectangle.
                Vector2 position = projectile.position;
                dust = Main.dust[Terraria.Dust.NewDust(position, 30, 30, 127, 0f, 0f, 0, new Color(255, 255, 255), 1f)];
                dust.noGravity = true;
                dust.fadeIn = 1.25f;
            }
            timer++;
            if (timer == 5)
            {
                Projectile.NewProjectile(projectile.Center, projectile.velocity.RotatedByRandom(MathHelper.ToRadians(75)), mod.ProjectileType("FlamesProj"), projectile.damage, projectile.knockBack, Main.myPlayer);
                timer = 0;
            }

        }

        public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
        {
            target.AddBuff(BuffID.OnFire, 300);
        }
    }
}
