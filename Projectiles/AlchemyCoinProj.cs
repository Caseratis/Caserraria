using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Caserraria.Projectiles
{
    public class AlchemyCoinProj : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Alchemy Coin");     //The English name of the projectile
            Main.projFrames[projectile.type] = 8;
        }

        public override void SetDefaults()
        {
            projectile.width = 22;
            projectile.height = 22;
            projectile.timeLeft = 600;
            projectile.penetrate = 7;
            projectile.friendly = true;
            projectile.hostile = false;
            projectile.tileCollide = true;
            projectile.ignoreWater = true;
            projectile.magic = true;
            projectile.aiStyle = 1;

        }

        public override void AI()
        {
            projectile.rotation = 0;

            if (projectile.velocity.X > 0)
            {
                projectile.velocity.X = 5;
            }

            if (projectile.velocity.X < 0)
            {
                projectile.velocity.X = -5;
            }
            if (projectile.velocity.X == 0)
            {
                projectile.Kill();
            }

            if (++projectile.frameCounter >= 8)
            {
                projectile.frameCounter = 0;
                if (++projectile.frame >= 4)
                {
                    projectile.frame = 0;
                }
            }
        }

       

        public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
        {
            projectile.velocity.X *= -1;
            projectile.velocity.Y = -3;
            if (target.type != NPCID.TargetDummy && target.lifeMax > 5 && !target.SpawnedFromStatue)
            {
                if (Main.rand.Next(0, 2) == 0)
                {
                    Item.NewItem((int)target.position.X, (int)target.position.Y, target.width, target.height, ItemID.CopperCoin, Main.rand.Next(1, 100));
                }
                if (Main.rand.Next(0, 4) == 0)
                {
                    Item.NewItem((int)target.position.X, (int)target.position.Y, target.width, target.height, ItemID.SilverCoin, Main.rand.Next(1, 100));
                }
                if (Main.rand.Next(0, 6) == 0)
                {
                    Item.NewItem((int)target.position.X, (int)target.position.Y, target.width, target.height, ItemID.GoldCoin, 1);
                }
            }
        }

        public override bool OnTileCollide(Vector2 oldVelocity)
        {

            return false;
        }


        public override bool TileCollideStyle(ref int width, ref int height, ref bool fallThrough)
        {
            fallThrough = false;
            return true;
        }
    }
}