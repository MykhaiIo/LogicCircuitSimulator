using System;

namespace LogicCircuitSimulator
{
    public static class UnitTest
    {
        private static class Require
        {
            public static void That(bool expression, string exceptionMessage = "")
            {
                if (!expression) throw new InvalidProgramException(exceptionMessage);
            }
        }
        public static void TestCase_2AND()
        {
            Logic l_0 = new Logic(LogicValue.LOGIC_0);
            Logic l_1 = new Logic(LogicValue.LOGIC_1);
            Logic U = new Logic(LogicValue.UNINITIALIZED);
            Logic result;

            //U AND U
            result = U & U;
            Require.That(result.Value == LogicValue.UNINITIALIZED, "Result of U AND U isn't U.");
            
            //U AND 0
            result = U & l_0;
            Require.That(result.Value == LogicValue.LOGIC_0, "Result of U AND 0 isn't 0.");
            
            //U AND 1
            result = U & l_1;
            Require.That(result.Value == LogicValue.UNINITIALIZED, "Result of U AND 1 isn't U.");
            
            //0 AND U
            result = l_0 & U;
            Require.That(result.Value == LogicValue.LOGIC_0, "Result of 0 AND U isn't 0.");
            
            //0 AND 0
            result = l_0 & l_0;
            Require.That(result.Value == LogicValue.LOGIC_0, "Result of 0 AND 0 isn't 0.");
           
            //0 AND 1
            result = l_0 & l_1;
            Require.That(result.Value == LogicValue.LOGIC_0, "Result of 0 AND 1 isn't 0.");
            
            //1 AND U
            result = l_1 & U;
            Require.That(result.Value == LogicValue.UNINITIALIZED, "Result of 1 AND U isn't U.");
            
            //1 AND 0
            result = l_1 & l_0;
            Require.That(result.Value == LogicValue.LOGIC_0, "Result of 1 AND 0 isn't 0.");

            Console.WriteLine("AND passed.");

            //1 AND 1
            result = l_1 & l_1;
            Require.That(result.Value == LogicValue.LOGIC_1, "Result of 1 AND 1 isn't 1.");
            Console.WriteLine("1 AND 1 passed.");
        }
        public static void TestCase_2OR()
        {
            Logic l_0 = new Logic(LogicValue.LOGIC_0);
            Logic l_1 = new Logic(LogicValue.LOGIC_1);
            Logic U = new Logic(LogicValue.UNINITIALIZED);
            Logic result;

            //U OR U
            result = U | U;
            Require.That(result.Value == LogicValue.UNINITIALIZED, "Result of U OR U isn't U.");
            
            //U OR 0
            result = U | l_0;
            Require.That(result.Value == LogicValue.UNINITIALIZED, "Result of U OR 0 isn't U.");
            
            //U OR 1
            result = U | l_1;
            Require.That(result.Value == LogicValue.LOGIC_1, "Result of U OR 1 isn't 1.");
            
            //0 OR U
            result = l_0 | U;
            Require.That(result.Value == LogicValue.UNINITIALIZED, "Result of 0 OR U isn't U.");
            
            //0 OR 0
            result = l_0 | l_0;
            Require.That(result.Value == LogicValue.LOGIC_0, "Result of 0 OR 0 isn't 0.");
            
            //0 OR 1
            result = l_0 | l_1;
            Require.That(result.Value == LogicValue.LOGIC_1, "Result of 0 OR 1 isn't 1.");
           
            //1 OR U
            result = l_1 | U;
            Require.That(result.Value == LogicValue.LOGIC_1, "Result of 1 OR U isn't 1.");
            
            //1 OR 0
            result = l_1 | l_0;
            Require.That(result.Value == LogicValue.LOGIC_1, "Result of 1 OR 0 isn't 1.");
            
            //1 OR 1
            result = l_1 | l_1;
            Require.That(result.Value == LogicValue.LOGIC_1, "Result of 1 OR 1 isn't 1.");

            Console.WriteLine("OR passed.");
        }
        public static void TestCase_2XOR()
        {
            Logic l_0 = new Logic(LogicValue.LOGIC_0);
            Logic l_1 = new Logic(LogicValue.LOGIC_1);
            Logic U = new Logic(LogicValue.UNINITIALIZED);
            Logic result;

            //U XOR U
            result = U ^ U;
            Require.That(result.Value == LogicValue.UNINITIALIZED, "Result of U XOR U isn't U.");
            
            //U XOR 0
            result = U ^ l_0;
            Require.That(result.Value == LogicValue.UNINITIALIZED, "Result of U XOR 0 isn't U.");
           
            //U XOR 1
            result = U ^ l_1;
            Require.That(result.Value == LogicValue.UNINITIALIZED, "Result of U XOR 1 isn't U.");
           
            //0 XOR U
            result = l_0 ^ U;
            Require.That(result.Value == LogicValue.UNINITIALIZED, "Result of 0 XOR U isn't U.");
            
            //0 XOR 0
            result = l_0 ^ l_0;
            Require.That(result.Value == LogicValue.LOGIC_0, "Result of 0 XOR 0 isn't 0.");
           
            //0 XOR 1
            result = l_0 ^ l_1;
            Require.That(result.Value == LogicValue.LOGIC_1, "Result of 0 XOR 1 isn't 1.");
          
            //1 XOR U
            result = l_1 ^ U;
            Require.That(result.Value == LogicValue.UNINITIALIZED, "Result of 1 XOR U isn't U.");
     
            //1 XOR 0
            result = l_1 ^ l_0;
            Require.That(result.Value == LogicValue.LOGIC_1, "Result of 1 XOR 0 isn't 1.");
           
            //1 XOR 1
            result = l_1 ^ l_1;
            Require.That(result.Value == LogicValue.LOGIC_0, "Result of 1 XOR 1 isn't 0.");

            Console.WriteLine("XOR passed.");
        }
        public static void TestCase_NOT()
        {
            Logic l_0 = new Logic(LogicValue.LOGIC_0);
            Logic l_1 = new Logic(LogicValue.LOGIC_1);
            Logic U = new Logic(LogicValue.UNINITIALIZED);
            Logic result;

            //NOT U
            result = !U;
            Require.That(result.Value == LogicValue.UNINITIALIZED, "Result of NOT U isn't U.");
            
            //NOT 0
            result = !l_0;
            Require.That(result.Value == LogicValue.LOGIC_1, "Result of NOT 0 isn't 1.");

            //NOT 1
            result = !l_1;
            Require.That(result.Value == LogicValue.LOGIC_0, "Result of NOT 1 isn't 0.");

            Console.WriteLine("NOT passed.");
        }

        public static void TestCase_AndGateSimulation()
        {
            void VerifyStates(Pin x1_out_pin, string x1_out_val,
                              Pin x2_out_pin, string x2_out_val,
                              Pin and_in0_pin, string and_in0_val,
                              Pin and_in1_pin, string and_in1_val,
                              Pin and_out_pin, string and_out_val,
                              Pin y1_in_pin, string y1_in_val,
                              Logic y1_res_real, string y1_res_exp)
            {
                Require.That(x1_out_pin.State.Value == Logic.StringToLogicValue(x1_out_val));
                Require.That(x2_out_pin.State.Value == Logic.StringToLogicValue(x2_out_val));

                Require.That(and_in0_pin.State.Value == Logic.StringToLogicValue(and_in0_val));
                Require.That(and_in1_pin.State.Value == Logic.StringToLogicValue(and_in1_val));
                Require.That(and_out_pin.State.Value == Logic.StringToLogicValue(and_out_val));

                Require.That(y1_in_pin.State.Value == Logic.StringToLogicValue(y1_in_val));
                Require.That(y1_res_real.Value == Logic.StringToLogicValue(y1_res_exp));
            }

            Circuit cir = new Circuit();
            InTerminal x1 = new InTerminal();
            cir.AddElement(x1);
            InTerminal x2 = new InTerminal();
            cir.AddElement(x2);
            AND and = new AND();
            cir.AddElement(and);
            OutTerminal y1 = new OutTerminal();
            cir.AddElement(y1);

            Pin x1_out = x1.GetPin(PinSide.OUTPUT, 0);
            Pin x2_out = x2.GetPin(PinSide.OUTPUT, 0);
            Pin and_in0 = and.GetPin(PinSide.INPUT, 0);
            Pin and_in1 = and.GetPin(PinSide.INPUT, 1);
            Pin and_out = and.GetPin(PinSide.OUTPUT, 0);
            Pin y1_in = y1.GetPin(PinSide.INPUT, 0);

            cir.Connect(x1_out, and_in0);
            cir.Connect(x2_out, and_in1);
            cir.Connect(and_out, y1_in);

            x1.SimulationInputValue = new Logic(LogicValue.LOGIC_1);
            x2.SimulationInputValue = new Logic(LogicValue.LOGIC_1);

            cir.RestartSimulation();
            VerifyStates(x1_out, "U", x2_out, "U", and_in0, "U", and_in1, "U", and_out, "U", y1_in, "U", y1.SimulationResult, "U");
            cir.NextMoment();
            VerifyStates(x1_out, "1", x2_out, "1", and_in0, "1", and_in1, "1", and_out, "U", y1_in, "U", y1.SimulationResult, "U");
            cir.NextMoment();
            VerifyStates(x1_out, "1", x2_out, "1", and_in0, "1", and_in1, "1", and_out, "1", y1_in, "1", y1.SimulationResult, "U");
            cir.NextMoment();
            VerifyStates(x1_out, "1", x2_out, "1", and_in0, "1", and_in1, "1", and_out, "1", y1_in, "1", y1.SimulationResult, "1");
            Console.WriteLine("TestCase_AndGateSimulation passed.");
        }

        public static void TestCase_Nand_Nor_GatesSimulation()
        {
            void VerifyStates(Pin x1_out_pin, string x1_out_val,
                              Pin x2_out_pin, string x2_out_val,
                              Pin x3_out_pin, string x3_out_val,
                              Pin nand_in0_pin, string nand_in0_val,
                              Pin nand_in1_pin, string nand_in1_val,
                              Pin nand_out_pin, string nand_out_val,
                              Pin nor_in0_pin, string nor_in0_val,
                              Pin nor_in1_pin, string nor_in1_val,
                              Pin nor_out_pin, string nor_out_val,
                              Pin y1_in_pin, string y1_in_val,
                              Logic y1_res_real, string y1_res_exp)
            {
                Require.That(x1_out_pin.State.Value == Logic.StringToLogicValue(x1_out_val));
                Require.That(x2_out_pin.State.Value == Logic.StringToLogicValue(x2_out_val));
                Require.That(x3_out_pin.State.Value == Logic.StringToLogicValue(x3_out_val));

                Require.That(nand_in0_pin.State.Value == Logic.StringToLogicValue(nand_in0_val));
                Require.That(nand_in1_pin.State.Value == Logic.StringToLogicValue(nand_in1_val));
                Require.That(nand_out_pin.State.Value == Logic.StringToLogicValue(nand_out_val));

                Require.That(nor_in0_pin.State.Value == Logic.StringToLogicValue(nor_in0_val));
                Require.That(nor_in1_pin.State.Value == Logic.StringToLogicValue(nor_in1_val));
                Require.That(nor_out_pin.State.Value == Logic.StringToLogicValue(nor_out_val));

                Require.That(y1_in_pin.State.Value == Logic.StringToLogicValue(y1_in_val));
                Require.That(y1_res_real.Value == Logic.StringToLogicValue(y1_res_exp));
            }

            Circuit cir = new Circuit();
            InTerminal x1 = new InTerminal();
            cir.AddElement(x1);
            InTerminal x2 = new InTerminal();
            cir.AddElement(x2);
            InTerminal x3 = new InTerminal();
            cir.AddElement(x3);

            NAND nand = new NAND();
            cir.AddElement(nand);

            NOR nor = new NOR();
            cir.AddElement(nor);

            OutTerminal y1 = new OutTerminal();
            cir.AddElement(y1);

            Pin x1_out = x1.GetPin(PinSide.OUTPUT, 0);
            Pin x2_out = x2.GetPin(PinSide.OUTPUT, 0);
            Pin x3_out = x3.GetPin(PinSide.OUTPUT, 0);
            Pin nand_in0 = nand.GetPin(PinSide.INPUT, 0);
            Pin nand_in1 = nand.GetPin(PinSide.INPUT, 1);
            Pin nand_out = nand.GetPin(PinSide.OUTPUT, 0);
            Pin nor_in0 = nor.GetPin(PinSide.INPUT, 0);
            Pin nor_in1 = nor.GetPin(PinSide.INPUT, 1);
            Pin nor_out = nor.GetPin(PinSide.OUTPUT, 0);
            Pin y1_in = y1.GetPin(PinSide.INPUT, 0);

            cir.Connect(x1_out, nand_in0);
            cir.Connect(x2_out, nand_in1);
            cir.Connect(nand_out, nor_in0);
            cir.Connect(x3_out, nor_in1);
            cir.Connect(nor_out, y1_in);

            x1.SimulationInputValue = new Logic(LogicValue.LOGIC_1);
            x2.SimulationInputValue = new Logic(LogicValue.LOGIC_1);
            x3.SimulationInputValue = new Logic(LogicValue.LOGIC_0);

            cir.RestartSimulation();
            VerifyStates(
                x1_out, "U", x2_out, "U", x3_out, "U", 
                nand_in0, "U", nand_in1, "U", nand_out, "U", 
                nor_in0, "U", nor_in1, "U", nor_out, "U",
                y1_in, "U", y1.SimulationResult, "U");

            cir.NextMoment();
            VerifyStates(
               x1_out, "1", x2_out, "1", x3_out, "0",
               nand_in0, "1", nand_in1, "1", nand_out, "U",
               nor_in0, "U", nor_in1, "0", nor_out, "U",
               y1_in, "U", y1.SimulationResult, "U");

            cir.NextMoment();
            VerifyStates(
               x1_out, "1", x2_out, "1", x3_out, "0",
               nand_in0, "1", nand_in1, "1", nand_out, "0",
               nor_in0, "0", nor_in1, "0", nor_out, "U",
               y1_in, "U", y1.SimulationResult, "U");

            cir.NextMoment();
            VerifyStates(
                x1_out, "1", x2_out, "1", x3_out, "0",
               nand_in0, "1", nand_in1, "1", nand_out, "0",
               nor_in0, "0", nor_in1, "0", nor_out, "1",
               y1_in, "1", y1.SimulationResult, "U");

            cir.NextMoment();
            VerifyStates(
                x1_out, "1", x2_out, "1", x3_out, "0",
               nand_in0, "1", nand_in1, "1", nand_out, "0",
               nor_in0, "0", nor_in1, "0", nor_out, "1",
               y1_in, "1", y1.SimulationResult, "1");

            Console.WriteLine("TestCase_Nand_Nor_GatesSimulation passed.");
        }
    }
}
