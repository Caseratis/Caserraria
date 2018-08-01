using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Caserraria.Projectiles
{
    public class ThunderboltProj : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Lightning Bolt");     //The English name of the projectile
        }

        public override void SetDefaults()
        {
            projectile.width = 18;
            projectile.height = 18;
            projectile.friendly = true;
            projectile.penetrate = 1;
            projectile.timeLeft = 60;
            projectile.tileCollide = true;
            projectile.melee = true;
            projectile.ignoreWater = true;
            projectile.alpha = 150;
            projectile.aiStyle = 0;
        }

        public override void AI()
        {
            projectile.rotation = projectile.velocity.ToRotation() + MathHelper.ToRadians(135f);
            if (projectile.spriteDirection == -1)
            {
                projectile.rotation -= MathHelper.ToRadians(90f);
            }
        }
    }
}