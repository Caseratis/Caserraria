using Microsoft.Xna.Framework;
using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Caserraria.Items.InventoryItems
{
    public class OrnatePlate : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Ornate Plate");
            Tooltip.SetDefault("Favorite to activate" + Environment.NewLine + "'Flashy! Acrobatic! Useless!'");
        }

        public override void SetDefaults()
        {
            item.width = 38;
            item.height = 24;
            item.value = Item.buyPrice(platinum: 1);
            item.rare = 8;
        }

        public override void UpdateInventory(Player player)
        {
            if (item.favorited)
            {
                MyPlayer p = player.GetModPlayer<MyPlayer>();
                p.Ornate = true;
            }
            
            
        }

        

    }
}
