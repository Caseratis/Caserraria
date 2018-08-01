using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Caserraria.Items.Weapons
{
    public class ForestAxeWeapon : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Axe of the Forest");
            Tooltip.SetDefault("Right click to fire a wave of energy");
        }

        public override void SetDefaults()
        {
            item.damage = 25;
            item.melee = true;
            item.width = 48;
            item.height = 40;
            item.useTime = 20;
            item.useAnimation = 20;
            item.axe = 25;          //How much axe power the weapon has, note that the axe power displayed in-game is this value multiplied by 5
            item.useStyle = 1;
            item.knockBack = 6;
            item.value = 10000;
            item.rare = 1;
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;
            item.shoot = mod.ProjectileType("AxeWave");
            item.shootSpeed = 13f;
        }

        public override bool AltFunctionUse(Player player)
        {
            return true;
        }

        public override bool CanUseItem(Player player)
        {
            if (player.altFunctionUse == 2)
            {
                item.useTime = 40;
                item.useAnimation = 40;
                item.shoot = mod.ProjectileType("AxeWave");
            }
            else
            {
                item.useTime = 20;
                item.useAnimation = 20;
                item.shoot = 0;
            }
            return base.CanUseItem(player);
        }

        public override void MeleeEffects(Player player, Rectangle hitbox)
        {
            if (Main.rand.Next(10) == 0)
            {
                int dust = Dust.NewDust(new Vector2(hitbox.X, hitbox.Y), hitbox.Width, hitbox.Height, 3);
            }
        }
    }
}