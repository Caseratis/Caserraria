using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Caserraria.Projectiles
{
    public class FlamesProj : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Inferno");     //The English name of the projectile
        }

        public override void SetDefaults()
        {
            projectile.magic = true;
            projectile.width = 15;
            projectile.height = 15;
            projectile.friendly = true;
            projectile.penetrate = 3;
            projectile.timeLeft = 15;
            projectile.tileCollide = true;
            projectile.alpha = 255;
            projectile.usesLocalNPCImmunity = true;
        }

        public override void AI()
        {
            for (int k = 0; k < 15; k++)
            {

                Dust dust;
                // You need to set position depending on what you are doing. You may need to subtract width/2 and height/2 as well to center the spawn rectangle.
                Vector2 position = projectile.Center;
                dust = Main.dust[Terraria.Dust.NewDust(position, 15, 15, 127, 0f, 0f, 0, new Color(255, 255, 255), 1f)];
                dust.noGravity = true;
            }
            

        }

        public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
        {
            target.AddBuff(BuffID.OnFire, 300);
        }
    }
}
