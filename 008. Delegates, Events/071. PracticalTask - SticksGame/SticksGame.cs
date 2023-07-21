// Practice of using delegates, events
namespace SticksGame
{
    public class SticksGame
    {
        private readonly Random randomizer;

        public int InitialSticksNumber { get; }

        public Player Turn { get; private set; }

        public int RemainingSticks { get; private set; }

        public GameStatus GameStatus { get; private set; }

        public event Action<int>? ComputerPlayed;
        public event EventHandler<int>? HumanTurnToPlay;

        public event Action<Player>? EndOfGame;

        public SticksGame(int initialSticksNumber, Player whoMakesFirstMove)
        {
            if (initialSticksNumber < 7 || initialSticksNumber > 30)
                throw new ArgumentException("Initial number of sticks should be >= 7 and <= 30");

            randomizer = new Random();
            GameStatus = GameStatus.NotStarted;
            InitialSticksNumber = initialSticksNumber;
            RemainingSticks = InitialSticksNumber;
            Turn = whoMakesFirstMove;
        }

        public void HumanTakes(int sticks)
        {
            if (sticks < 1 || sticks > 3)
            {
                throw new ArgumentException("You can take from 1 to 3 sticks in a single move");
            }

            if (sticks > RemainingSticks)
            {
                throw new ArgumentException($"You can't take more than remaining. Remains:{RemainingSticks}");
            }

            TakeSticks(sticks);
        }

        public void Start()
        {
            if (GameStatus == GameStatus.GameIsOver)
                RemainingSticks = InitialSticksNumber;

            if (GameStatus == GameStatus.InProgress)
            {
                throw new InvalidOperationException("Can't call Start when game is already in progress.");
            }

            GameStatus = GameStatus.InProgress;
            while (GameStatus == GameStatus.InProgress)
            {
                if (Turn == Player.Computer)
                {
                    CompMakesMove();
                }
                else
                {
                    HumanMakesMove();
                }

                FireEndOfGameIfRequired();

                Turn = Turn == Player.Computer ? Player.Human : Player.Computer;
            }
        }

        private void FireEndOfGameIfRequired()
        {
            if (RemainingSticks == 0)
            {
                GameStatus = GameStatus.GameIsOver;
                if (EndOfGame != null)
                    EndOfGame(Turn == Player.Computer ? Player.Human : Player.Computer);
            }
        }

        private void HumanMakesMove()
        {
            if (HumanTurnToPlay != null)
                HumanTurnToPlay(this, RemainingSticks);
        }

        private void CompMakesMove()
        {
            int maxNumber = RemainingSticks >= 3 ? 3 : RemainingSticks;
            int sticks = randomizer.Next(1, maxNumber);

            TakeSticks(sticks);
            if (ComputerPlayed != null)
                ComputerPlayed(sticks);
        }

        private void TakeSticks(int sticks)
        {
            RemainingSticks -= sticks;
        }
    }
}
