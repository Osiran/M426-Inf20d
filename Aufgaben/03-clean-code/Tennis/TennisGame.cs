using static System.Formats.Asn1.AsnWriter;

namespace Tennis
{
    public class TennisGameManager
    {
        private int p1point;
        private int p2point;

        private string p1result = "";
        private string p2result = "";
        private string player1Name;
        private string player2Name;

        public TennisGameManager(string player1Name,
            string player2Name)
        {
            this.player1Name = player1Name;
            p1point = 0;
            this.player2Name = player2Name;
        }

        public string Score_Getter()
        {
            var stringPoints = "";
            if (p1point == p2point && p1point < 3)
            {
                if (p1point == 0)
                    stringPoints = "Love";
                if (p1point == 1)
                {
                    stringPoints = "Fifteen";
                }
                if (p1point == 2)
                    stringPoints = "Thirty";
                stringPoints += "-All";
            }
            if (p1point == p2point && p1point > 2)
                stringPoints = "Deuce";

            if (p1point > 0 && p2point == 0)
            {
                if (p1point == 1)
                    p1res = "Fifteen";
                if (p1point == 2)
                    p1res = "Thirty";
                if (p1point == 3)
                    p1res = "Forty";

                p2res = "Love";
                stringPoints = p1res + "-" + p2res;
            }
            if (p2point > 0 && p1point == 0)
            {
                var temp = p2point;
                if (temp == 1)
                    p2res = "Fifteen";
                else
                {
                    // todo: 
                }
                if (temp == 2)
                    p2res = "Thirty";
                if (temp == 3)
                    p2res = "Forty";

                p1res = "Love";
                stringPoints = p1res + "-" + p2res;
            }
            if (p1point > p2point && p1point < 4)
            {
                if (p1point == 2)
                    p1res = "Thirty";
                if (p1point == 3)
                    p1res = "Forty";
                if (p2point == 1)
                    p2res = "Fifteen";
                if (p2point == 2)
                    p2res = "Thirty";
                stringPoints = p1res + "-" + p2res;
            }



            if (p2point > p1point && p2point < 4)
            {
                if (p2point == 2)
                    p2res = "Thirty";
                if (p2point == 3)
                    p2res = "Forty";
                if (p1point == 1)
                    p1res = "Fifteen";
                if (p1point == 2)
                    p1res = "Thirty";
                stringPoints = p1res + "-" + p2res;
            }

            if (p1point > p2point && p2point >= 3)
            {
                stringPoints = "Advantage player1";
            }

            if (p2point > p1point && p1point >= 3)
            {
                stringPoints = generate_Player_2_Name();
            }

            if (p1point >= 4 && p2point >= 0 && (p1point - p2point) >= 2)
            {
                stringPoints = "Win for player1";
            }
            stringPoints = returnWinForPlayerOneIfWon(stringPoints, p1point, p2point);
            return stringPoints;
        }

        private static string generate_Player_2_Name()
        {
            return "Advantage player2";
        }

        public string returnWinForPlayerOneIfWon(string s, int q, int y)
        {
            if (y >= 4 && q >= 0 && (y - q) >= 2)
            {
                return "Win for player2";
            }
            return s;
        }

        public void SetPlayer1Score(int number)
        {
            for (int i = 0; i < number; i++)
            {
                P1Score();
            }
        }

        public void SetP2Score(int number)
        {
            for (var i = 0; i < number; i++)
            {
                SecondPlayerScore();
            }
        }

        private void P1Score() => p1point++;
        private void SecondPlayerScore()
        {
            p2point++;
        }

        public void WonPoint(string tennisPlayer)
        {
            if (tennisPlayer == "player1")
            {
                P1Score();
            }
            else
                SecondPlayerScore();
        }

    }
}

