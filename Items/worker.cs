using Terraria.ID;
using Terraria.ModLoader;

namespace accessory_craft.Items
{
	public class worker : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("worker"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("the mod won't work without it");
		}

		public override void SetDefaults() 
		{
			item.damage = 1;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 2;
			item.useAnimation = 2;
			item.useStyle = 1;
			item.knockBack = 10000;
			item.value = 10;
			item.rare = -12;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes() 
		{
			//AGLET
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.YellowDye, 1);
			recipe.AddIngredient(ItemID.LeadBar, 5);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.Aglet);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.YellowDye, 1);
			recipe.AddIngredient(ItemID.IronBar, 5);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.Aglet);
			recipe.AddRecipe();

			//HERMES BOOTS
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Silk, 10);
			recipe.AddIngredient(ItemID.SwiftnessPotion, 2);
			recipe.AddIngredient(ItemID.WoodGreaves, 1);
			recipe.AddTile(TileID.Loom);
			recipe.SetResult(ItemID.HermesBoots);
			recipe.AddRecipe();
			
			//JESUS BOOTS
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Waterleaf, 3);
			recipe.AddIngredient(ItemID.Leather, 5);
			recipe.AddIngredient(ItemID.WaterWalkingPotion, 5);
			recipe.AddTile(TileID.Loom);
			recipe.SetResult(ItemID.WaterWalkingBoots);
			recipe.AddRecipe();

			//FERAL CLAWS
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.JungleSpores, 5);
			recipe.AddIngredient(ItemID.Stinger, 5);
			recipe.AddIngredient(ItemID.Silk, 10);
			recipe.AddTile(TileID.Loom);
			recipe.SetResult(ItemID.FeralClaws);
			recipe.AddRecipe();

			//LAVA CHARM
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.LavaBucket, 2);
			recipe.AddIngredient(ItemID.IronBar, 10);
			recipe.AddIngredient(ItemID.Fireblossom, 3);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.LavaCharm);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.LavaBucket, 2);
			recipe.AddIngredient(ItemID.LeadBar, 10);
			recipe.AddIngredient(ItemID.Fireblossom, 3);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.LavaCharm);
			recipe.AddRecipe();

			//ICE SKATES
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.IceBlock, 50);
			recipe.AddIngredient(ItemID.Silk, 8);
			recipe.AddIngredient(ItemID.IronBar, 4);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.IceSkates);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.IceBlock, 50);
			recipe.AddIngredient(ItemID.Silk, 8);
			recipe.AddIngredient(ItemID.LeadBar, 4);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.IceSkates);
			recipe.AddRecipe();

			//ANKH SHIELD
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Obsidian, 1);
			recipe.AddIngredient(ItemID.ObsidianBrick, 1);
			recipe.AddIngredient(ItemID.ObsidianSkinPotion, 1);
			recipe.AddIngredient(ItemID.ObsidianSkull, 1);
			recipe.AddIngredient(ItemID.AshBlock, 1);
			recipe.AddIngredient(ItemID.SnowBlock, 1);
			recipe.AddTile(412);
			recipe.SetResult(ItemID.AnkhShield);
			recipe.AddRecipe();

			//REGENERATION BAND
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.LifeCrystal, 1);
			recipe.AddIngredient(ItemID.Silk, 8);
			recipe.AddIngredient(ItemID.IronBar, 4);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.BandofRegeneration);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.LifeCrystal, 1);
			recipe.AddIngredient(ItemID.Silk, 8);
			recipe.AddIngredient(ItemID.LeadBar, 4);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.BandofRegeneration);
			recipe.AddRecipe();

			//STARPOWER BAND
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.ManaCrystal, 1);
			recipe.AddIngredient(ItemID.Silk, 8);
			recipe.AddIngredient(ItemID.IronBar, 4);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.BandofStarpower);
			recipe.AddRecipe();
			
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.ManaCrystal, 1);
			recipe.AddIngredient(ItemID.Silk, 8);
			recipe.AddIngredient(ItemID.LeadBar, 4);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.BandofStarpower);
			recipe.AddRecipe();

			//LUCKY HOE
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Leather, 2);
			recipe.AddIngredient(ItemID.PlatinumBar, 5);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.LuckyHorseshoe);
			recipe.AddRecipe();
			
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Leather, 2);
			recipe.AddIngredient(ItemID.GoldBar, 5);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.LuckyHorseshoe);
			recipe.AddRecipe();

			//ANKLET OF WIND
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.JungleSpores, 5);
			recipe.AddIngredient(ItemID.Stinger, 5);
			recipe.AddIngredient(ItemID.Vine, 1);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.AnkletoftheWind);
			recipe.AddRecipe();
		}
	}
}