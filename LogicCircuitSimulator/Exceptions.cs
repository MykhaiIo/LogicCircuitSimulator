namespace LogicCircuitSimulator
{
    class InvalidPinSideException : System.Exception
    {
        public InvalidPinSideException()
            : base()
        { }

        public InvalidPinSideException(string message)
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

    class NumberOfPinsOutOfRangeException : System.Exception
    {
        public NumberOfPinsOutOfRangeException()
            : base()
        { }

        public NumberOfPinsOutOfRangeException(string message)
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

    class ElementHasConnectedPinsException : System.Exception
    {
        public ElementHasConnectedPinsException()
            : base()
        { }

        public ElementHasConnectedPinsException(string message)
            : base(message)
        { }
    }

    class ConnectedPinException : System.Exception
    {
        public ConnectedPinException()
            : base()
        { }

        public ConnectedPinException(string message)
            : base(message)
        { }
    }

    class ConnectToIdenticalSideException : System.Exception
    {
        public ConnectToIdenticalSideException()
            : base()
        { }

        public ConnectToIdenticalSideException(string message)
            : base(message)
        { }
    }
}
