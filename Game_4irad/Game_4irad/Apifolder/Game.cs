using System;
namespace FirApi
{
    public class Game
    {
		public int Game_ID;
        public int Player1_ID;
        public int Player2_ID;
        public string Status;
        public string Start_Time;
        public string Changed_Time;
        public string Player1;
        public string Player2;

        public const string STATUS_TIE = "tie";
        public const string STATUS_WAITFORP1 = "waiting for player 1";
        public const string STATUS_WAITFORP2 = "waiting for player 2";
        public const string STATUS_WONBYP1 = "won by player 1";
        public const string STATUS_WONBYP2 = "won by player 2";
    }
}
