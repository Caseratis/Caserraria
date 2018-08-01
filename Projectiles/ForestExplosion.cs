using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Caserraria.Projectiles
{
    public class ForestExplosion : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Forest Explosion");     //The English name of the projectile
        }

        public override void SetDefaults()
        {
            projectile.width = 40;
            projectile.height = 80;
            projectile.hostile = true;
            projectile.penetrate = -1;
            projectile.timeLeft = 3;
            projectile.tileCollide = false;
            projectile.alpha = 255;
        }

        public override void AI()
        {

            Dust dust;
            // You need to set position depending on what you are doing. You may need to subtract width/2 and height/2 as well to center the spawn rectangle.
            Vector2 position = projectile.position + projectile.velocity;
            dust = Main.dust[Terraria.Dust.NewDust(position, projectile.width, projectile.height, 3, 0f, 0f, 0, new Color(255, 255, 255), 1f)];
            dust = Main.dust[Terraria.Dust.NewDust(position, projectile.width, projectile.height, 3, 0f, 0f, 0, new Color(255, 255, 255), 1f)];
            dust = Main.dust[Terraria.Dust.NewDust(position, projectile.width, projectile.height, 3, 0f, 0f, 0, new Color(255, 255, 255), 1f)];
            dust.scale = 3;
            dust.noGravity = true;
        }
    }
}
