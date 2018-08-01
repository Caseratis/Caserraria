using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace Caserraria
{
    public class MyPlayer : ModPlayer
    {
        public static bool KShield = false;

        public override void ResetEffects()
        {
            KShield = false;
        }

        public override bool PreHurt(bool pvp, bool quiet, ref int damage, ref int hitDirection, ref bool crit,
            ref bool customDamage, ref bool playSound, ref bool genGore, ref PlayerDeathReason damageSource)
        {
            if (KShield == true && Main.rand.Next(0, 10) == 0)
            {
                damage = damage / 2;
            }
            return true;
        }
    }
}