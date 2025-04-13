namespace yeyuya_02_SnakeGameClassic
{
    internal class SnakeGameLogic : BaseGameLogc
    {
        private SnakeGamePlayState gameplayState = new SnakeGamePlayState();

        public void GotoGameplay()
        {
            gameplayState.Reset();
        }
        public override void OnArrowDown()
        {
            gameplayState.SetDirection(SnakeDir.Down);
        }

        public override void OnArrowLeft()
        {
            gameplayState.SetDirection(SnakeDir.Left);
        }

        public override void OnArrowRight()
        {
            gameplayState.SetDirection(SnakeDir.Right);
        }

        public override void OnArrowUp()
        {
            gameplayState.SetDirection(SnakeDir.Up);
        }

        public override void Update(float deltaTime)
        {
            gameplayState.Update(deltaTime);
        }
    }
}
