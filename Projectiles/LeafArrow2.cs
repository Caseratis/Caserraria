using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Caserraria.Projectiles
{
    public class LeafArrow2 : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Leaf Arrow2");     //The English name of the projectile
        }

        public override void SetDefaults()
        {
            projectile.width = 22;
            projectile.height = 34;
            projectile.friendly = true;
            projectile.penetrate = 3;
            projectile.timeLeft = 30000;
            projectile.tileCollide = true;
            projectile.thrown = true;
            projectile.ignoreWater = true;
            projectile.ranged = true;
        }
    }
}