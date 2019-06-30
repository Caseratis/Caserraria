
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Caserraria.Items.Weapons
{
    public class WarHorn : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("War Horn");
            Tooltip.SetDefault("Clear a space around you with a powerful blow!");
        }

        public override void SetDefaults()
        {
            item.damage = 65;
            item.magic = true;
            item.noMelee = true;
            item.mana = 20;
            item.width = 24;
            item.height = 26;
            item.useTime = 60;
            item.useAnimation = 60;
            item.useStyle = 5;
            item.noMelee = true; //so the item's animation doesn't do damage
            item.knockBack = 8;
            item.value = Item.buyPrice(gold: 15);
            item.rare = 4;
            item.autoReuse = true;
            item.shootSpeed = 0f;
            item.shoot = mod.ProjectileType("WarHornProj");
            
        }
        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            Main.PlaySound(SoundLoader.customSoundType, (int)player.position.X, (int)player.position.Y, mod.GetSoundSlot(SoundType.Custom, "Sounds/WarHornSound"), 1, Main.rand.NextFloat(-0.5f, 0.5f));
            return true;
        }

       

        public override Vector2? HoldoutOffset()
        {
            return new Vector2(-3, 8);
            
        }
    }
}