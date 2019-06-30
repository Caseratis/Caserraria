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
        public bool Ornate = false;
        public bool MoonWalk = false;
        public bool Oof = false;
        public bool hoardCalled = false;

        public override void ResetEffects()
        {
            Ornate = false;
            MoonWalk = false;
            Oof = false;
    }

        public override void UpdateEquips(ref bool wallSpeedBuff, ref bool tileSpeedBuff, ref bool tileRangeBuff)
        {
            if (Ornate)
            {
                MyPlayer p = player.GetModPlayer<MyPlayer>();
                if (player.velocity.Y != 0)
                {
                    if (player.velocity.X > 0)
                    {
                        player.fullRotationOrigin = player.Center - player.position;
                        player.fullRotation += 0.25f;
                    }

                    if (player.velocity.X < 0)
                    {
                        player.fullRotationOrigin = player.Center - player.position;
                        player.fullRotation -= 0.25f;
                    }
                }

                else
                {
                    player.fullRotation = 0f;
                }
            }
        }

        public override void PreUpdateMovement()
        {
            if (MoonWalk == true)
            {
                if (player.controlRight == true)
                {
                    player.direction = 0;
                }

                if (player.controlLeft == true)
                {
                    player.direction = 1;
                }
            }
        }

        public override bool PreHurt(bool pvp, bool quiet, ref int damage, ref int hitDirection, ref bool crit, ref bool customDamage, ref bool playSound, ref bool genGore, ref PlayerDeathReason damageSource)
        {
            if (Oof)
            {
                playSound = false;
            }
            return true;
        }
        public override void Hurt(bool pvp, bool quiet, double damage, int hitDirection, bool crit)
        {
            if (Oof)
            {
                Main.PlaySound(SoundLoader.customSoundType, (int)player.position.X, (int)player.position.Y, mod.GetSoundSlot(SoundType.Custom, "Sounds/OOF"));
            }
        }
        
            
        
    }
}