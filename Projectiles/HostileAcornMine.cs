using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Caserraria.Projectiles
{
    public class HostileAcornMine : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Acorn Mine");
        }

        public override void SetDefaults()
        {
            projectile.width = 20;
            projectile.height = 20;
            projectile.timeLeft = 420;
            projectile.penetrate = 1;
            projectile.hostile = true;
            projectile.tileCollide = true;
            projectile.ignoreWater = true;
            projectile.aiStyle = 14;
        }

        public override bool TileCollideStyle(ref int width, ref int height, ref bool fallThrough)
        {
            fallThrough = false;
            width = 20;
            height = 20;
            return true;
        }
        public override void OnHitPlayer(Player target, int damage, bool crit)
        {
            projectile.Kill();
        }
        public override bool PreKill(int timeLeft)
        {
                Projectile.NewProjectile(projectile.Center.X, projectile.Center.Y, 0, 0, mod.ProjectileType("ForestExplosion"), projectile.damage, 1, 255, 0f, 0f);
            
            return true;
        }
    }
}