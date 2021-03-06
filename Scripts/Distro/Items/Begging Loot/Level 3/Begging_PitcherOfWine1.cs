using System;
using Server;

namespace Server.Items
{
	public class Begging_PitcherOfWine1 : Pitcher
	{
		[Constructable]
		public Begging_PitcherOfWine1()
			: base( BeverageType.Wine )
		{
			ItemID = 0x1F9B;
		}

		public Begging_PitcherOfWine1( Serial serial )
			: base( serial )
		{
		}

		public override void GetProperties( ObjectPropertyList list )
		{
			base.GetProperties( list );

			list.Add( 1075129 ); // Acquired by begging
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );

			writer.Write( (int) 1 ); // version
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );

			reader.ReadInt();
		}
	}
}