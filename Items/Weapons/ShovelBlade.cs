using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Caserraria.Items.Weapons
{
    public class ShovelBlade : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Shovel Blade");
            Tooltip.SetDefault("Shovel drop onto enemies!");
        }

        public override void SetDefaults()
        {
            item.damage = 30;
            item.melee = true;
            item.noMelee = false;
            item.width = 16;
            item.height = 60;
            item.useTime = 15;
            item.useAnimation = 15;
            item.useStyle = 5;
            item.knockBack = 4;
            item.value = Item.buyPrice(gold: 1);
            item.rare = 1;
            item.autoReuse = true;
            item.useTurn = true;
        }
        public override bool CanUseItem(Player player)
        {
            if (player.velocity.Y == 0)
            {
                return false;
            }

            else
            {
                return true;
            }
        }

        public override Vector2? HoldoutOffset()
        {
            return new Vector2(-5, 25);

        }

        public override void OnHitNPC(Player player, NPC target, int damage, float knockBack, bool crit)
        {
            player.velocity.Y = -10;
        }

        public override void UseItemHitbox(Player player, ref Rectangle hitbox, ref bool noHitbox)
        {
            hitbox.Y += 85;
            hitbox.X = (int)player.Center.X - 9;
        }
    }
}