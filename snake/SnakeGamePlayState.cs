using yeyuya_02_SnakeGameClassic.shared;

namespace yeyuya_02_SnakeGameClassic.snake
{
    internal class SnakeGamePlayState : BaseGameState
    {
        const char squareSymbol = '■';
        private struct Cell
        {
            public int x; public int y;

            public Cell(int x, int y)
            {
                this.x = x; this.y = y;
            }
        }

        public int fieldWidth { get; set; }
        public int fieldHeight { get; set; }

        private List<Cell> _body = new();
        private SnakeDir currentDir = SnakeDir.Left;

        private float _timeToMove = 0f;

        public void SetDirection(SnakeDir dir)
        {
            currentDir = dir;
        }

        public override void Reset()
        {
            _body.Clear();
            var middleY = fieldHeight / 2;
            var middleX = fieldWidth / 2;
            currentDir = SnakeDir.Left;
            _body.Add(new(middleX + 3, middleY));
            _timeToMove = 0f;
        }

        public override void Update(float deltaTime)
        {
            _timeToMove -= deltaTime;

            if (_timeToMove > 0f)
                return;

            _timeToMove = 1f / 4;
            var head = _body[0];
            var nextCell = ShiftTo(head, currentDir);

            _body.RemoveAt(_body.Count - 1);
            _body.Insert(0, nextCell);

            //Console.WriteLine($"{_body[0].x}, {_body[0].y}");
        }

        private Cell ShiftTo(Cell from, SnakeDir toDir)
        {
            switch (toDir)
            {
                case SnakeDir.Up:
                    return new Cell(from.x, from.y - 1);
                case SnakeDir.Down:
                    return new Cell(from.x, from.y + 1);
                case SnakeDir.Left:
                    return new Cell(from.x - 1, from.y);
                case SnakeDir.Right:
                    return new Cell(from.x + 1, from.y);
            }

            return from;
        }

        public override void Draw(ConsoleRenderer renderer)
        {
            foreach (Cell cell in _body)
            {
                renderer.SetPixel(cell.x, cell.y, squareSymbol, 3);
            }
        }
    }
}
