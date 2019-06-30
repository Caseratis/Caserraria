
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Caserraria.Items.Weapons
{
    public class AlchemyCoin : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Alchemy Coin");
            Tooltip.SetDefault("Toss a coin for a chance at riches.");
        }

        public override void SetDefaults()
        {
            item.damage = 25;
            item.magic = true;
            item.noMelee = true;
            item.mana = 12;
            item.width = 22;
            item.height = 22;
            item.useTime = 50;
            item.useAnimation = 50;
            item.useStyle = 1;
            item.noMelee = true; //so the item's animation doesn't do damage
            item.knockBack = 3;
            item.value = Item.buyPrice(gold: 6);
            item.rare = 2;
            item.UseSound = SoundID.Item8;
            item.autoReuse = true;
            item.shootSpeed = 3f;
            item.shoot = mod.ProjectileType("AlchemyCoinProj");
            item.noUseGraphic = true;
        }
    }
}