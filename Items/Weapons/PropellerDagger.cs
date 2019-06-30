using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Caserraria.Items.Weapons
{
    public class PropellerDagger : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Propeller Dagger");
            Tooltip.SetDefault("Soar through the sky blade first!");
        }
        
        public override void SetDefaults()
        {
            item.damage = 50;
            item.melee = true;
            item.noMelee = false;
            item.width = 22;
            item.height = 22;
            item.useTime = 0;
            item.useAnimation = 60;
            item.useStyle = 5;
            item.knockBack = 5;
            item.value = Item.buyPrice(gold: 10);
            item.rare = 3;
            item.autoReuse = false;
        }

        public override void UseStyle(Player player)
        {
            if (player.direction == 1)
            {
                player.itemRotation = 44.5f;
            }
            else
            {
                player.itemRotation = -44.5f;
            }
        }
        public override bool UseItem(Player player)
        {

                if (player.direction == 1)
                {
                    player.velocity.X = 10;
                }
                else
                {
                player.velocity.X = -10;
                }

                player.velocity.Y = -0.333f;
                
            
            return true;
        }

        public override Vector2? HoldoutOffset()
        {
            return new Vector2(15, -10);

        }

        public override void UseItemHitbox(Player player, ref Rectangle hitbox, ref bool noHitbox)
        {
            if (player.direction == 1)
            {
                hitbox.X = (int)player.position.X + 20;
                hitbox.Y = (int)player.position.Y + 15;
            }
            else
            {
                hitbox.X = (int)player.position.X - 20;
                hitbox.Y = (int)player.position.Y + 15;
            }
        }
    }
}