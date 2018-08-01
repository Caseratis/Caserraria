using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Caserraria.Projectiles
{
    public class LeafArrow : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Leaf Arrow");     //The English name of the projectile
        }

        public override void SetDefaults()
        {
            projectile.width = 18;
            projectile.height = 32;
            projectile.timeLeft = 2500000;
            projectile.penetrate = 1;
            projectile.friendly = true;
            projectile.hostile = false;
            projectile.tileCollide = true;
            projectile.ignoreWater = false;
            projectile.ranged = true;
            projectile.aiStyle = 1;
            projectile.arrow = true;
            aiType = ProjectileID.WoodenArrowFriendly;
        }

        public override bool PreKill(int timeLeft)
        {
            Projectile.NewProjectile(projectile.Center.X, projectile.Center.Y - Main.screenHeight, 0, 25, mod.ProjectileType("LeafArrow2"), projectile.damage/2, 0, Main.myPlayer, 0f, 0f); //Spawning a projectile
            Projectile.NewProjectile(projectile.Center.X - 25, projectile.Center.Y - Main.screenHeight, 0, 25, mod.ProjectileType("LeafArrow2"), projectile.damage / 2, 0, Main.myPlayer, 0f, 0f); //Spawning a projectile
            Projectile.NewProjectile(projectile.Center.X + 25, projectile.Center.Y - Main.screenHeight, 0, 25, mod.ProjectileType("LeafArrow2"), projectile.damage / 2, 0, Main.myPlayer, 0f, 0f); //Spawning a projectile
            return true;
        }
    }
}