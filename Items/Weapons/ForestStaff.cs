
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Caserraria.Items.Weapons
{
    public class ForestStaff : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Forest Staff");
            Tooltip.SetDefault("Rains forest bolts from the sky");
            Item.staff[item.type] = true;
        }

        public override void SetDefaults()
        {
            item.CloneDefaults(ItemID.Starfury);
            item.damage = 12;
            item.magic = true;
            item.melee = false;
            item.noMelee = true;
            item.mana = 7;
            item.width = 50;
            item.height = 48;
            item.useTime = 10;
            item.useAnimation = 25;
            item.useStyle = 5;
            item.noMelee = true; //so the item's animation doesn't do damage
            item.knockBack = 3;
            item.value = 10000;
            item.rare = 1;
            item.UseSound = SoundID.Item20;
            item.autoReuse = true;
            item.shootSpeed = 20f;
            item.alpha = 0;
        }

        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            damage = damage / 2;
            type = mod.ProjectileType("GoodForestBolt");
            return base.Shoot(player, ref position, ref speedX, ref speedY, ref type, ref damage, ref knockBack);
        }
	}
}