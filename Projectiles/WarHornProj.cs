using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Caserraria.Projectiles
{
    public class WarHornProj : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("War Horn");     //The English name of the projectile
        }

        public override void SetDefaults()
        {
            projectile.width = 500;
            projectile.height = 500;
            projectile.timeLeft = 1;
            projectile.penetrate = -1;
            projectile.friendly = true;
            projectile.hostile = false;
            projectile.tileCollide = false;
            projectile.ignoreWater = true;
            projectile.magic = true;
            projectile.aiStyle = -1;
            projectile.alpha = 255;
        }

        public override void AI()
        {
            for (int i = 0; i < 60; i++)
            {
                Dust d = Dust.NewDustPerfect(Main.player[projectile.owner].Center + Main.rand.NextVector2CircularEdge(250, 250), 143);
                Dust f = Dust.NewDustPerfect(Main.player[projectile.owner].Center + Main.rand.NextVector2CircularEdge(83, 83), 143);
                Dust g = Dust.NewDustPerfect(Main.player[projectile.owner].Center + Main.rand.NextVector2CircularEdge(166, 166), 143);
                d.noGravity = true;
                f.noGravity = true;
                g.noGravity = true;
            }
        }
    }
}