using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Caserraria.Projectiles
{
    public class SpectralBlastParts : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Spectral Blast Parts");     //The English name of the projectile
        }

        public override void SetDefaults()
        {
            projectile.CloneDefaults(ProjectileID.LostSoulFriendly);
            aiType = ProjectileID.LostSoulFriendly;
            projectile.ranged = true;
            projectile.magic = false;
            projectile.timeLeft = 120;
        }

        
    }
    
}