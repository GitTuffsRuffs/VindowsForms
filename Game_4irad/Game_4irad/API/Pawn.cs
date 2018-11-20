using System;
namespace FirApi
{
	public class Pawn
	{
		const string Player1_Color = "Red";
		const string Player2_Color = "Blue";

		public int Game_ID;
		public int X;
		public int Y;
		public string Color;
		public int NR;
		public int Player {
			get => this.Color == Player1_Color ? 1 : 2;
			set => this.Color = value == 1 ? Player1_Color : Player2_Color;
		}
	}
}
