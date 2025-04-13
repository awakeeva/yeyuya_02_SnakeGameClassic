namespace yeyuya_02_SnakeGameClassic
{
    internal abstract class BaseGameState
    {
        public abstract void Update(float deltaTime);
        public abstract void Reset();
    }
}
