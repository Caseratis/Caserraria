using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Caserraria.Projectiles
{
    public class ThrowingAnchorProj : ModProjectile
    {
        public float rot;
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Throwing Anchor");     //The English name of the projectile
        }

        public override void SetDefaults()
        {
            projectile.width = 22;
            projectile.height = 22;
            projectile.timeLeft = 600;
            projectile.penetrate = 25;
            projectile.friendly = true;
            projectile.hostile = false;
            projectile.tileCollide = false;
            projectile.ignoreWater = true;
            projectile.thrown = true;
            projectile.aiStyle = 1;
            
        }
        public override bool? CanCutTiles()
        {
            return false;
        }
        public override void AI()
        {
            rot += 0.1f;
            if (rot >= 0 && rot <= 1)
            {
                projectile.rotation = 90;

            }
            if (rot >= 1 && rot <= 2)
            {
                projectile.rotation = 180;

            }
            if (rot >= 2 && rot <= 3)
            {
                projectile.rotation = 270;

            }
            if (rot >= 3)
            {
                projectile.rotation = 360;
                rot = 0;
            }
        }
    }
}