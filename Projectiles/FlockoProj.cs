using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Caserraria.Projectiles
{
    public class FlockoProj : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Flocko's Child");     //The English name of the projectile
        }

        public override void SetDefaults()
        {
            projectile.width = 50;
            projectile.height = 50;
            projectile.timeLeft = 12000;
            projectile.penetrate = 1;
            projectile.friendly = true;
            projectile.hostile = false;
            projectile.tileCollide = true;
            projectile.ignoreWater = true;
            projectile.thrown = true;
            projectile.aiStyle = 2;
        }
        public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
        {
            target.AddBuff(BuffID.Frostburn, 300);
        }
        public override bool PreKill(int timeLeft)
        {
            int numberProjectiles = 7 + Main.rand.Next(0, 4);
            for (int i = 0; i < numberProjectiles; i++)
            {
                Projectile.NewProjectile(projectile.Center.X, projectile.Center.Y, Main.rand.Next(-5, 6), Main.rand.Next(-5, 6), mod.ProjectileType("FlockoShard"), projectile.damage, projectile.knockBack, Main.myPlayer, 0f, 0f); //Spawning a projectile
            }
            Main.PlaySound(SoundID.Item27.WithVolume(0.5f), (int)projectile.Center.X, (int)projectile.Center.Y);

            return true;
        }
    }
}