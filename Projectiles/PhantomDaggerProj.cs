using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Caserraria.Projectiles
{
    public class PhantomDaggerProj : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Phantom Dagger Proj");     //The English name of the projectile
        }

        public override void SetDefaults()
        {
            projectile.CloneDefaults(ProjectileID.MagicDagger);
            projectile.tileCollide = false;
            projectile.penetrate = -1;
            projectile.alpha = 50;
            projectile.timeLeft = 120;
            aiType = ProjectileID.VampireKnife;
        }

        public override void AI()
        {
            
        }
    }
}