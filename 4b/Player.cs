namespace _4b
{
    public class Player
    {
        private string _name;
        private string _position;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Position
        {
            get { return _position; }
            set { _position = value; }
        }

        public Player(string name, string position)
        {
            Name = name;
            Position = position;
        }
    }
}