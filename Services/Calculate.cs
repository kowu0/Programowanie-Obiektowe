namespace Lab1.Services
{
    public class Calculate
    {
        public Calculate(int value)
        {
            Value = value;
        }

        private int Value { get; set; }

        public void Add(int value)
        {
            Value += value;
        }

        public void NotAdd(int value)
        {
            Value -= value;
        }

        public int GetValue()
        {
            return Value;
        }

    }
}
