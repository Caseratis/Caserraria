using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Caserraria.Projectiles
{
    public class SpectralBlast : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Spectral Blast");     //The English name of the projectile
        }

        public override void SetDefaults()
        {
            projectile.ranged = true;
            projectile.width = 30;
            projectile.height = 30;
            projectile.friendly = true;
            projectile.penetrate = 1;
            projectile.timeLeft = 45;
            projectile.tileCollide = true;
            projectile.alpha = 255;
        }

        public override void AI()
        {
            for (int k = 0; k < 10; k++)
            {

                Dust dust;
                // You need to set position depending on what you are doing. You may need to subtract width/2 and height/2 as well to center the spawn rectangle.
                Vector2 position = projectile.position;
                dust = Main.dust[Terraria.Dust.NewDust(position, 30, 30, 175, 0f, 0f, 0, new Color(255, 255, 255), 2f)];
                dust.noGravity = true;
                dust.fadeIn = 3f;
            }
            


        }

        public override bool PreKill(int timeLeft)
        {
            Projectile.NewProjectile(projectile.Center.X, projectile.Center.Y, 2, 2, mod.ProjectileType("SpectralBlastParts"), projectile.damage, 0, Main.myPlayer, 0f, 0f); //Spawning a projectile
            Projectile.NewProjectile(projectile.Center.X, projectile.Center.Y, 2, -2, mod.ProjectileType("SpectralBlastParts"), projectile.damage, 0, Main.myPlayer, 0f, 0f); //Spawning a projectile
            Projectile.NewProjectile(projectile.Center.X, projectile.Center.Y, -2, 2, mod.ProjectileType("SpectralBlastParts"), projectile.damage, 0, Main.myPlayer, 0f, 0f); //Spawning a projectile
            Projectile.NewProjectile(projectile.Center.X, projectile.Center.Y, -2, -2, mod.ProjectileType("SpectralBlastParts"), projectile.damage, 0, Main.myPlayer, 0f, 0f); //Spawning a projectile
            return true;
        }
    }
}
