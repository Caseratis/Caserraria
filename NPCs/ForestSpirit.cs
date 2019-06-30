using Microsoft.Xna.Framework;
using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Caserraria.NPCs
{
    [AutoloadBossHead]
    public class ForestSpirit : ModNPC
    {
        int fallTimer;
        int teleportTimer;
        int acornTimer;
        bool Stage = false;
        float movespeed;
        float speed;
        bool AxeExists = false;
        int animationTimer = 0;
        int Choice;

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Forest Spirit");
            Main.npcFrameCount[npc.type] = 10;
        }

        public override void SetDefaults()
        {
            npc.width = 80;
            npc.height = 80;
            npc.damage = 25;
            npc.defense = 3;
            npc.lifeMax = 1500;
            npc.HitSound = SoundID.NPCHit44;
            npc.DeathSound = SoundID.NPCDeath6;
            npc.value = 10f;
            npc.knockBackResist = 0f;
            npc.aiStyle = 44;
            npc.noTileCollide = true;
            npc.boss = true;
        }

        public override void FindFrame(int frameHeight)
        {
            animationTimer++;
            if (animationTimer == 10)
            {
                npc.frame.Y += frameHeight;
                animationTimer = 0;
            }

            if (npc.frame.Y == frameHeight*10)
            {
                npc.frame.Y = frameHeight;
            }
        }

        public override void AI()
        {


            if (Main.player[npc.target].statLife == 0 || Main.dayTime == false) //Despawning
            {
                Dust dust;
                // You need to set position depending on what you are doing. You may need to subtract width/2 and height/2 as well to center the spawn rectangle.
                Vector2 position = npc.position + npc.velocity;
                dust = Main.dust[Terraria.Dust.NewDust(position, npc.width, npc.height, 3, 0f, 0f, 0, new Color(255, 255, 255), 1f)];
                dust.scale = 2;
                dust.noGravity = true;
                npc.velocity.Y = 1000;
                if (npc.timeLeft > 10)
                {
                    npc.timeLeft = 10;
                }
            }
            // Thanks Blushie
            Player P = Main.player[npc.target]; // Player targeting

            Vector2 moveTo = P.Center + new Vector2(0f, 0f);
            // Movement
            speed = 2;

            Vector2 move = moveTo - npc.Center; //this is how much your boss wants to move
            float magnitude = (float)Math.Sqrt(move.X * move.X + move.Y * move.Y); //fun with the Pythagorean Theorem
            move *= speed / magnitude; //this adjusts your boss's speed so that its speed is always constant
            npc.velocity = move;

            // Shooting
            Vector2 vector8 = new Vector2(npc.position.X + (npc.width / 2), npc.position.Y + (npc.height / 2));
            float rotation = (float)Math.Atan2(vector8.Y - (P.position.Y + (P.height * 0.5f)), vector8.X - (P.position.X + (P.width * 0.5f)));

            fallTimer++;
            if (fallTimer == 60) //Falling Leaves Attack
            {
                fallTimer = 0;
                Projectile.NewProjectile(P.Center.X - 300, P.Center.Y - 500, 0, 7, mod.ProjectileType("ForestBolt"), 10, 1);
                Projectile.NewProjectile(P.Center.X - 150, P.Center.Y - 500, 0, 7, mod.ProjectileType("ForestBolt"), 10, 1);
                Projectile.NewProjectile(P.Center.X, P.Center.Y - 500, 0, 7, mod.ProjectileType("ForestBolt"), 10, 1);
                Projectile.NewProjectile(P.Center.X + 150, P.Center.Y - 500, 0, 7, mod.ProjectileType("ForestBolt"), 10, 1);
                Projectile.NewProjectile(P.Center.X + 300, P.Center.Y - 500, 0, 7, mod.ProjectileType("ForestBolt"), 10, 1);

            }

            if (npc.life < npc.lifeMax * .75)
            {
                teleportTimer++;
                if (teleportTimer >= 300)
                {
                    Dust dust;
                    // You need to set position depending on what you are doing. You may need to subtract width/2 and height/2 as well to center the spawn rectangle.
                    Vector2 position = npc.position + npc.velocity;
                    dust = Main.dust[Terraria.Dust.NewDust(position, npc.width, npc.height, 3, 0f, 0f, 0, new Color(255, 255, 255), 1f)];
                    dust = Main.dust[Terraria.Dust.NewDust(position, npc.width, npc.height, 3, 0f, 0f, 0, new Color(255, 255, 255), 1f)];
                    dust = Main.dust[Terraria.Dust.NewDust(position, npc.width, npc.height, 3, 0f, 0f, 0, new Color(255, 255, 255), 1f)];
                    dust.scale = 2;
                    dust.noGravity = true;

                    teleportTimer = 0;
                    if (npc.spriteDirection == -1)
                    {
                        npc.position.X = P.position.X - 500;
                    }
                    if (npc.spriteDirection == 1)
                    {
                        npc.position.X = P.position.X + 500;
                    }
                }
            }

            if (npc.life < npc.lifeMax * .50)
            {
                acornTimer++;
                if (acornTimer == 45) //Acorn Mine Attack
                {
                    acornTimer = 0;
                    Projectile.NewProjectile(npc.Center.X, npc.Center.Y, Main.rand.Next(-3, 3), -5, mod.ProjectileType("HostileAcornMine"), 10, 1);
                }

                
            }

            if (P.position.X > npc.position.X) //Changing where the sprite faces
            {
                npc.spriteDirection = 1;
            }

            if (P.position.X < npc.position.X)
            {
                npc.spriteDirection = -1;
            }
        }
        

        public override void BossLoot(ref string name, ref int potionType)
        {
            Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.Wood, Main.rand.Next(50, 75));
            if (!Main.expertMode) //Normal mode loot
            {
                Choice = Main.rand.Next(0, 3);

                if (Choice == 0)
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("ForestBow"), 1);
                }
                if (Choice == 1)
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("ForestStaff"), 1);
                }
                if (Choice == 2)
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("ForestAxeWeapon"), 1);
                }
            }

            if (Main.expertMode) //Expert mode loot
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("ForestTreasureBag"), 1);
            }
            MyWorld.downedForestSpirit = true;

            Dust dust;
            // You need to set position depending on what you are doing. You may need to subtract width/2 and height/2 as well to center the spawn rectangle.
            Vector2 position = npc.position + npc.velocity;
            dust = Main.dust[Terraria.Dust.NewDust(position, npc.width, npc.height, 3, 0f, 0f, 0, new Color(255, 255, 255), 1f)];
            dust.scale = 2;
            dust.noGravity = true;

        }
    }
}