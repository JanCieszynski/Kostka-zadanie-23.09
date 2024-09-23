namespace Kostka
{
    public partial class MainPage : ContentPage
    {
        int count = 0;
        int score = 0;

        public MainPage()
        {
            InitializeComponent();
        }
        private void RollDice(object sender, EventArgs e)
        {
            Random random = new Random();
            int[] dice = new int[5];
            for (int i = 0; i < dice.Length; i++)
            {
                dice[i] = random.Next(1,7);
            }
            int RollScore = 0;
            for (int i = 0; i <= 6; i++)
            {
                int count = 0;
                for (int j = 0; j < dice.Length; j++)
                {
                    if(dice[j] == i)
                    {
                        count++;
                    }
                }
                RollScore += count * i;
            }
            Dice0.Source = "k6_" + dice[0] + ".png";
            Dice1.Source = "k6_" + dice[1] + ".png";
            Dice2.Source = "k6_" + dice[2] + ".png";
            Dice3.Source = "k6_" + dice[3] + ".png";
            Dice4.Source = "k6_" + dice[4] + ".png";
            RollScoreLabel.Text = "Wynik tego losowania: " + RollScore;
            score += RollScore;
            ScoreLabel.Text = "Wynik gry: " + score;
        }
      private void ResetScore(object sender, EventArgs e)
        {
            score = 0;
            ScoreLabel.Text = "Wynik gry: " + score;
        }

    }

}
