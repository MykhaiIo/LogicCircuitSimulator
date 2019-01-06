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

    class PinIndexOutOfRangeException : System.Exception
    {
        public PinIndexOutOfRangeException()
            : base()
        { }

        public PinIndexOutOfRangeException(string message)
            : base(message)
        { }
    }

    class AlreadyDisconnectedPinException : System.Exception
    {
        public AlreadyDisconnectedPinException()
            : base()
        { }

        public AlreadyDisconnectedPinException(string message)
            : base(message)
        { }
    }
}
