
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Caserraria.Items.Weapons
{
    public class ChaosSphere : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Chaos Sphere");
            Tooltip.SetDefault("An orb of boundless combat potential. Give it a good throw! ");
        }

        public override void SetDefaults()
        {
            item.damage = 20;
            item.magic = true;
            item.noMelee = true;
            item.mana = 12;
            item.width = 22;
            item.height = 22;
            item.useTime = 15;
            item.useAnimation = 30;
            item.reuseDelay = 20;
            item.useStyle = 1;
            item.noMelee = true; //so the item's animation doesn't do damage
            item.knockBack = 3;
            item.value = Item.buyPrice(gold: 4);
            item.rare = 1;
            item.UseSound = SoundID.Item8;
            item.autoReuse = true;
            item.shootSpeed = 6f;
            item.shoot = mod.ProjectileType("ChaosSphereProj");
            item.noUseGraphic = true;
        }
    }
}