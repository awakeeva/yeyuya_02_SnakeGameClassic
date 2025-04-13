namespace yeyuya_02_SnakeGameClassic
{
    internal abstract class BaseGameLogc : ConsoleInput.IArrowListener
    {
        public abstract void OnArrowDown();

        public abstract void OnArrowLeft();

        public abstract void OnArrowRight();

        public abstract void OnArrowUp();

        public abstract void Update(float deltaTime);

        public void InitializeInput(ConsoleInput input)
        {
            input.Subscribe(this);
        }
    }
}
