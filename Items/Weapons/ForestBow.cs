
using Microsoft.Xna.Framework;
using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Caserraria.Items.Weapons
{
    public class ForestBow : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Forest Bow");
            Tooltip.SetDefault("Converts wooden arrows into Leaf Arrows");
        }

        public override void SetDefaults()
        {
            item.damage = 17;
            item.ranged = true;
            item.melee = false;
            item.noMelee = true;
            item.width = 20;
            item.height = 54;
            item.useTime = 25;
            item.useAnimation = 25;
            item.useStyle = 5;
            item.noMelee = true; //so the item's animation doesn't do damage
            item.knockBack = 3;
            item.value = 1000;
            item.rare = 1;
            item.UseSound = SoundID.Item5;
            item.autoReuse = true;
            item.shootSpeed = 20f;
            item.alpha = 0;
            item.shoot = 10;
            item.useAmmo = AmmoID.Arrow;
        }

        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            if (type == ProjectileID.WoodenArrowFriendly) // or ProjectileID.WoodenArrowFriendly
            {
                type = mod.ProjectileType("LeafArrow"); // or ProjectileID.FireArrow;
            }

            return true;
        }
    }
}