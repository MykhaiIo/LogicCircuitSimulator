namespace LogicCircuitSimulator
{
    enum PinSide : byte { INPUT, OUTPUT };

    class Pin
    {
        public Pin(PinSide side)
        {
            Side = side;
            State = new Logic(LogicValue.UNINITIALIZED);
            connected_pin = null;
        }

        public PinSide Side { get; private set; }
        public Logic State { get; set; }
        private Pin connected_pin;
        public Pin ConnectedPin
        {
            get { return connected_pin; }
            set
            {
                if (value != null)
                    if (value.Side == this.Side)
                        throw new ConnectToIdenticalSideException();
                connected_pin = value;
            }
        }
    }
}
