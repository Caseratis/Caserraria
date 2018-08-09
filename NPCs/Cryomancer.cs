using Microsoft.Xna.Framework;
using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Caserraria.NPCs
{
    public class Cryomancer : ModNPC
    {
        int shootTimer;
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Cryomancer");
        }

        public override void SetDefaults()
        {
            npc.width = 42;
            npc.height = 76;
            npc.damage = 60;
            npc.defense = 3;
            npc.lifeMax = 100;
            npc.HitSound = SoundID.NPCHit1;
            npc.DeathSound = SoundID.NPCDeath6;
            npc.value = 500f;
            npc.knockBackResist = 0f;
            npc.aiStyle = 2;
            npc.noTileCollide = true;
            npc.scale = .75f;
        }

        public override void AI()
        {
            shootTimer++;
            float Speed = 10;
            Player P = Main.player[npc.target];
            Vector2 vector8 = new Vector2(npc.position.X + (npc.width / 2), npc.position.Y + (npc.height / 2));
            float rotation = (float)Math.Atan2(vector8.Y - (P.position.Y + (P.height * 0.5f)), vector8.X - (P.position.X + (P.width * 0.5f)));
            if (shootTimer == 100)
            {
                shootTimer = 0;
                Projectile.NewProjectile(vector8.X, vector8.Y, (float)((Math.Cos(rotation) * Speed) * -1), (float)((Math.Sin(rotation) * Speed) * -1), ProjectileID.Fireball, 15, 0f, 0);
            }

            if (P.position.X > npc.position.X)
            {
                npc.spriteDirection = 1;
            }

            if (P.position.X < npc.position.X)
            {
                npc.spriteDirection = -1;
            }
            Dust dust;
            // You need to set position depending on what you are doing. You may need to subtract width/2 and height/2 as well to center the spawn rectangle.
            Vector2 position = npc.position + npc.velocity;
            dust = Main.dust[Terraria.Dust.NewDust(position, npc.width, npc.height, 127, 0f, 0f, 0, new Color(255, 255, 255), 1f)];

        }


        public override void NPCLoot()
        {
            Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.GuideVoodooDoll, 1);

        }
    }
}