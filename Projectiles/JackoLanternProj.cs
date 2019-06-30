using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Caserraria.Projectiles
{
    public class JackoLanternProj : ModProjectile
    {
        int speed = 0;
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Spoopy Pumpkin");     //The English name of the projectile
        }

        public override void SetDefaults()
        {
            projectile.width = 32;
            projectile.height = 32;
            projectile.timeLeft = 12000;
            projectile.penetrate = 1;
            projectile.friendly = true;
            projectile.hostile = false;
            projectile.tileCollide = true;
            projectile.ignoreWater = true;
            projectile.thrown = true;
            projectile.aiStyle = 2;
        }
        public override void AI()
        {
            
            if (speed >= 10)
            {
                speed = 0;
                Projectile.NewProjectile(projectile.Center.X, projectile.Center.Y, 0, 0, Main.rand.Next(400, 403), projectile.damage, projectile.knockBack, Main.myPlayer, 0f, 0f); //Spawning a projectile
            }
            
        }
        public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
        {
            target.AddBuff(BuffID.OnFire, 300);
        }
        public override bool PreKill(int timeLeft)
        {
            int numberProjectiles = 4 + Main.rand.Next(0, 3);
            for (int i = 0; i < numberProjectiles; i++)
            {
                Projectile.NewProjectile(projectile.Center.X, projectile.Center.Y, Main.rand.Next(-6, 7), Main.rand.Next(-6, 7), Main.rand.Next(400, 403), projectile.damage, projectile.knockBack, Main.myPlayer, 0f, 0f); //Spawning a projectile
            }
            Main.PlaySound(SoundID.NPCHit1.WithVolume(0.5f), (int)projectile.Center.X, (int)projectile.Center.Y);

            return true;
        }
    }
}