using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Caserraria.Projectiles
{
    public class SolarWasp : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Solar Wasp");     //The English name of the projectile
            Main.projFrames[projectile.type] = 4;
        }

        public override void SetDefaults()
        {
            projectile.width = 8;
            projectile.height = 8;
            projectile.aiStyle = 36;
            projectile.friendly = true;
            projectile.penetrate = 4;
            projectile.alpha = 255;
            projectile.timeLeft = 600;
            projectile.magic = true;
            projectile.extraUpdates = 3;
            projectile.usesLocalNPCImmunity = true;
            projectile.localNPCHitCooldown = 1;
            projectile.tileCollide = false;
        }

        public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
        {
            target.immune[projectile.owner] = 1;
        }



    }
}