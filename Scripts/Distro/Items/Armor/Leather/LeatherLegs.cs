using System;
using Server.Items;
using Server.Engines.Craft;

namespace Server.Items
{
	[Alterable( typeof( DefTailoring ), typeof( GargishLeatherLeggings ) )]
	[FlipableAttribute( 0x13cb, 0x13d2 )]
	public class LeatherLegs : BaseArmor
	{
		public override int BasePhysicalResistance { get { return 2; } }
		public override int BaseFireResistance { get { return 4; } }
		public override int BaseColdResistance { get { return 3; } }
		public override int BasePoisonResistance { get { return 3; } }
		public override int BaseEnergyResistance { get { return 3; } }

		public override int InitMinHits { get { return 30; } }
		public override int InitMaxHits { get { return 40; } }

		public override int StrengthReq { get { return 20; } }

		public override ArmorMaterialType MaterialType { get { return ArmorMaterialType.Leather; } }
		public override CraftResource DefaultResource { get { return CraftResource.RegularLeather; } }

		[Constructable]
		public LeatherLegs()
			: base( 0x13CB )
		{
			Weight = 4.0;
		}

		public LeatherLegs( Serial serial )
			: base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );

			writer.Write( (int) 0 ); // version
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );

			/*int version = */
			reader.ReadInt();
		}
	}
}