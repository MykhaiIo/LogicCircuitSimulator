namespace LogicCircuitSimulator
{
    enum LogicValue : byte {UNINITIALIZED, LOGIC_0, LOGIC_1};

    class Logic
    {
        public LogicValue Value { get; private set; }
        public Logic(LogicValue value)
        {
            Value = value;
        }

        public static Logic operator &(Logic l, Logic r)
        {
            LogicValue[,] and_table = 
            {
                //U 0 1 | 
                //------|--
                //U 0 U | U
                //0 0 0 | 0
                //U 0 1 | 1
                {LogicValue.UNINITIALIZED, LogicValue.LOGIC_0, LogicValue.UNINITIALIZED},
                {LogicValue.LOGIC_0, LogicValue.LOGIC_0, LogicValue.LOGIC_0 },
                {LogicValue.UNINITIALIZED, LogicValue.LOGIC_0, LogicValue.LOGIC_1 }
            };

            LogicValue rv = and_table[(byte)l.Value, (byte)r.Value];
            return new Logic(rv);
        }

        public static Logic operator |(Logic l, Logic r)
        {
            LogicValue[,] or_table =
            {
                //U 0 1 |
                //------|--
                //U U 1 | U
                //U 0 1 | 0
                //1 1 1 | 1
                {LogicValue.UNINITIALIZED, LogicValue.UNINITIALIZED, LogicValue.LOGIC_1},
                {LogicValue.UNINITIALIZED, LogicValue.LOGIC_0, LogicValue.LOGIC_1},
                {LogicValue.LOGIC_1, LogicValue.LOGIC_1, LogicValue.LOGIC_1}
            };

            LogicValue rv = or_table[(byte)l.Value, (byte)r.Value];
            return new Logic(rv);
        }

        public static Logic operator ^(Logic l, Logic r)
        {
            LogicValue[,] xor_table =
            {
                //U 0 1 |
                //------|--
                //U U U | U
                //U 0 1 | 0
                //U 1 0 | 1
                {LogicValue.UNINITIALIZED, LogicValue.UNINITIALIZED, LogicValue.UNINITIALIZED},
                {LogicValue.UNINITIALIZED, LogicValue.LOGIC_0, LogicValue.LOGIC_1},
                {LogicValue.UNINITIALIZED, LogicValue.LOGIC_1, LogicValue.LOGIC_0}
            };

            LogicValue rv = xor_table[(byte)l.Value, (byte)r.Value];
            return new Logic(rv);
        }

        public static Logic operator !(Logic l)
        {
            LogicValue[] not_table =
            {
                //U 0 1 |
                //------|--
                //U 1 0 |
                LogicValue.UNINITIALIZED, LogicValue.LOGIC_1, LogicValue.LOGIC_0
            };

            LogicValue rv = not_table[(byte)l.Value];
            return new Logic(rv);
        }

        public override string ToString()
        {
            switch (Value)
            {
                case LogicValue.LOGIC_0:
                    return "0";
                case LogicValue.LOGIC_1:
                    return "1";
                case LogicValue.UNINITIALIZED:
                    return "U";
                default:
                    throw new System.NotImplementedException();
            }
        }

        static public LogicValue StringToLogicValue(string str)
        {
            switch (str)
            {
                case "0":
                    return LogicValue.LOGIC_0;
                case "1":
                    return LogicValue.LOGIC_1;
                case "U":
                    return LogicValue.UNINITIALIZED;
                default:
                    throw new System.ArgumentException("Invalid string equivalent of LogicValue.");
            }
        }
    }

    
}
