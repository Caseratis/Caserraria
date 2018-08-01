using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Caserraria.Projectiles
{
    public class LightningBoltProj : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Lightning Bolt");     //The English name of the projectile
        }

        public override void SetDefaults()
        {
            projectile.width = 22;
            projectile.height = 34;
            projectile.friendly = true;
            projectile.penetrate = 10;
            projectile.timeLeft = 10;
            projectile.tileCollide = false;
            projectile.thrown = true;
            projectile.ignoreWater = true;
        }

        public override void AI()
        {
            Dust dust;
            // You need to set position depending on what you are doing. You may need to subtract width/2 and height/2 as well to center the spawn rectangle.
            Vector2 position = projectile.position + projectile.velocity;
            dust = Main.dust[Terraria.Dust.NewDust(position, projectile.width, projectile.height, 88, 0f, 0f, 0, new Color(255, 255, 255), 1f)];
            dust.noGravity = true;
        }
    }
}