using System;
using Server;
using Server.Gumps;
using Server.Network;

namespace Server
{
	public class VirtueStatusGump : Gump
	{
		public override int TypeID { get { return 0x2715; } }

		private Mobile m_Beholder;

		public VirtueStatusGump( Mobile beholder )
			: base( 0, 0 )
		{
			m_Beholder = beholder;

			AddPage( 0 );

			AddImage( 30, 40, 2080 );
			AddImage( 47, 77, 2081 );
			AddImage( 47, 147, 2081 );
			AddImage( 47, 217, 2081 );
			AddImage( 47, 267, 2083 );
			AddImage( 70, 213, 2091 );

			AddPage( 1 );

			AddKRHtmlLocalized( 0, 0, 0, 0, 1011012, false, false ); // CANCEL

			AddHtmlLocalized( 140, 73, 200, 20, 1077972, false, false ); // The Virtues
			AddHtmlLocalized( 75, 224, 220, 60, 1052062, false, false ); // Click on a blue gem to view your status in that virtue.

			AddKRHtmlLocalized( 0, 0, 0, 0, 1078075, false, false ); // Pick a virtue from the list below

			AddHtmlLocalized( 80, 100, 100, 40, 1051000, false, false ); // Humility
			AddHtmlLocalized( 80, 129, 100, 40, 1051001, false, false ); // Sacrifice
			AddHtmlLocalized( 80, 159, 100, 40, 1051002, false, false ); // Compassion
			AddHtmlLocalized( 80, 189, 100, 40, 1051003, false, false ); // Spirituality
			AddHtmlLocalized( 200, 100, 200, 40, 1051004, false, false ); // Valor
			AddHtmlLocalized( 200, 129, 200, 40, 1051005, false, false ); // Honor
			AddHtmlLocalized( 200, 159, 200, 40, 1051006, false, false ); // Justice
			AddHtmlLocalized( 200, 189, 200, 40, 1051007, false, false ); // Honesty			

			AddButton( 280, 43, 4014, 4014, 9, GumpButtonType.Reply, 0 );

			AddButton( 60, 100, 1210, 1210, 1, GumpButtonType.Reply, 0 );
			AddButton( 60, 129, 1210, 1210, 2, GumpButtonType.Reply, 0 );
			AddButton( 60, 159, 1210, 1210, 3, GumpButtonType.Reply, 0 );
			AddButton( 60, 189, 1210, 1210, 4, GumpButtonType.Reply, 0 );
			AddButton( 180, 100, 1210, 1210, 5, GumpButtonType.Reply, 0 );
			AddButton( 180, 129, 1210, 1210, 6, GumpButtonType.Reply, 0 );
			AddButton( 180, 159, 1210, 1210, 7, GumpButtonType.Reply, 0 );
			AddButton( 180, 189, 1210, 1210, 8, GumpButtonType.Reply, 0 );

			AddKRImage( 0, 0, -2402 );
			AddKRImage( 0, 0, -2402 );
			AddKRImage( 0, 0, -2402 );
			AddKRImage( 0, 0, -2402 );
			AddKRImage( 0, 0, -2402 );
			AddKRImage( 0, 0, -2402 );
			AddKRImage( 0, 0, -2402 );
			AddKRImage( 0, 0, -2402 );
		}

		public override void OnResponse( GameClient state, RelayInfo info )
		{
			switch ( info.ButtonID )
			{
				case 1:
					{
						m_Beholder.SendGump( new VirtueInfoGump( m_Beholder, VirtueName.Humility, 1052051 ) );
						break;
					}
				case 2:
					{
						m_Beholder.SendGump( new VirtueInfoGump( m_Beholder, VirtueName.Sacrifice, 1052053 ) );
						break;
					}
				case 3:
					{
						m_Beholder.SendGump( new VirtueInfoGump( m_Beholder, VirtueName.Compassion, 1053000 ) );
						break;
					}
				case 4:
					{
						m_Beholder.SendGump( new VirtueInfoGump( m_Beholder, VirtueName.Spirituality, 1052056 ) );
						break;
					}
				case 5:
					{
						m_Beholder.SendGump( new VirtueInfoGump( m_Beholder, VirtueName.Valor, 1054033 ) );
						break;
					}
				case 6:
					{
						m_Beholder.SendGump( new VirtueInfoGump( m_Beholder, VirtueName.Honor, 1052058 ) );
						break;
					}
				case 7:
					{
						m_Beholder.SendGump( new VirtueInfoGump( m_Beholder, VirtueName.Justice, 1052059 ) );
						break;
					}
				case 8:
					{
						m_Beholder.SendGump( new VirtueInfoGump( m_Beholder, VirtueName.Honesty, 1052060 ) );
						break;
					}
				case 9:
					{
						m_Beholder.SendGump( new VirtueGump( m_Beholder, m_Beholder ) );
						break;
					}
			}
		}
	}
}