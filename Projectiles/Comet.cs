using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Caserraria.Projectiles
{
    public class Comet : ModProjectile
    {
        private int Trail = 0;
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Comet");     //The English name of the projectile
        }

        public override void SetDefaults()
        {
            projectile.melee = true;
            projectile.width = 32;
            projectile.height = 32;
            projectile.friendly = true;
            projectile.penetrate = 5;
            projectile.timeLeft = 600;
            projectile.tileCollide = true;
        }

        public override void AI()
        {
            Trail++;
            if (Trail >= 5)
            {
                Trail = 0;
                Projectile.NewProjectile(projectile.Center.X, projectile.Center.Y, Main.rand.Next(-2, 3), Main.rand.Next(-2, 3), mod.ProjectileType("CometTrail"), projectile.damage, 1, Main.myPlayer, 0f, 0f);
            }
            


        }
    }
}
