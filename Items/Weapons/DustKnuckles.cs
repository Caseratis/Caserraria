using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using Caserraria.Items;
using Terraria.GameContent.Achievements;

namespace Caserraria.Items.Weapons
{
    public class DustKnuckles : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Dust Knuckles");
            Tooltip.SetDefault("Dash through blocks and foes alike!");
        }

        public override void SetDefaults()
        {
            item.damage = 30;
            item.melee = true;
            item.width = 48;
            item.height = 48;
            item.useTime = 15;
            item.useAnimation = 15;
            item.useStyle = 3;
            item.knockBack = 5f;
            item.value = Item.buyPrice(gold: 10);
            item.rare = 3;
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;
            item.useTurn = true;
            item.shoot = mod.ProjectileType("DustKnucklesBreak");
            
        }
        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            if (player.direction == 1)
            {
                Projectile.NewProjectile(player.Center.X + 13, player.Center.Y - 6, 0, 0, type, 0, 0, player.whoAmI);
            }

            else
            {
                Projectile.NewProjectile(player.Center.X - 13, player.Center.Y - 6, 0, 0, type, 0, 0, player.whoAmI);
            }

            if (player.direction == 1)
            {
                player.velocity.X = 5;
                player.velocity.Y = 0;
            }

            else
            {
                player.velocity.X = -5;
                player.velocity.Y = 0;
            }

            return false;
        }
        

        
    }
    
}