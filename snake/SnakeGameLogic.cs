using yeyuya_02_SnakeGameClassic.shared;

namespace yeyuya_02_SnakeGameClassic.snake;

internal class SnakeGameLogic : BaseGameLogic
{
    private SnakeGamePlayState gameplayState = new SnakeGamePlayState();

    public void GotoGameplay()
    {
        gameplayState.fieldHeight = screenHeight;
        gameplayState.fieldWidth = screenWidth;
        ChangeState(gameplayState);
        gameplayState.Reset();
    }
    public override void OnArrowDown()
    {
        if (currentState != gameplayState)
            return;
        gameplayState.SetDirection(SnakeDir.Down);
    }

    public override void OnArrowLeft()
    {
        if (currentState != gameplayState)
            return;
        gameplayState.SetDirection(SnakeDir.Left);
    }

    public override void OnArrowRight()
    {
        if (currentState != gameplayState)
            return;
        gameplayState.SetDirection(SnakeDir.Right);
    }

    public override void OnArrowUp()
    {
        if (currentState != gameplayState)
            return;
        gameplayState.SetDirection(SnakeDir.Up);
    }

    public override void Update(float deltaTime)
    {
        //gameplayState.Update(deltaTime);
        if (currentState != gameplayState)
        {
            GotoGameplay();
        }
    }

    public override ConsoleColor[] CreatePalette()
    {
        return
        [
            ConsoleColor.Green,
            ConsoleColor.Red,
            ConsoleColor.White,
            ConsoleColor.Blue,
        ];
    }
}
