namespace LogicCircuitSimulator
{
    class WrongPinSideException : System.Exception
    {
        public WrongPinSideException()
            : base()
        { }

        public WrongPinSideException(string message)
            : base(message)
        { }
    }
}
