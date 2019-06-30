
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Caserraria.Items.Weapons
{
    public class ThrowingAnchor : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Throwing Anchor");
            Tooltip.SetDefault("An unstoppable arc of destruction. Crush foes above and below!");
        }

        public override void SetDefaults()
        {
            item.damage = 30;
            item.thrown = true;
            item.noMelee = true;
            item.width = 22;
            item.height = 22;
            item.useTime = 50;
            item.useAnimation = 50;
            item.useStyle = 1;
            item.noMelee = true; //so the item's animation doesn't do damage
            item.knockBack = 3;
            item.value = Item.buyPrice(gold: 10);
            item.rare = 3;
            item.UseSound = SoundID.Item8;
            item.autoReuse = true;
            item.shootSpeed = 2f;
            item.shoot = mod.ProjectileType("ThrowingAnchorProj");
            item.noUseGraphic = true;
        }

        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
                Projectile.NewProjectile(player.position.X, player.position.Y, speedX, -7, type, item.damage, item.knockBack, Main.myPlayer, 0f, 0f); //Spawning a projectile
            return false;
        }
    }
}