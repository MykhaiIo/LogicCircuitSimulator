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
        public static void TestCase_LogicOperatorAnd()
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

            //1 AND 1
            result = l_1 & l_1;
            Require.That(result.Value == LogicValue.LOGIC_1, "Result of 1 AND 1 isn't 1.");
            Console.WriteLine("TestCase_LogicOperatorAnd passed.");
        }
        public static void TestCase_LogicOperatorOr()
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

            Console.WriteLine("TestCase_LogicOperatorOr passed.");
        }
        public static void TestCase_LogicOperatorXor()
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

            Console.WriteLine("TestCase_LogicOperatorXor passed.");
        }
        public static void TestCase_LogicOperatorNot()
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

            Console.WriteLine("TestCase_LogicOperatorNot passed.");
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

        public static void TestCase_Xnor_Xor_GatesSimulation()
        {
            void VerifyStates(Pin x1_out_pin, string x1_out_val,
                              Pin x2_out_pin, string x2_out_val,
                              Pin x3_out_pin, string x3_out_val,
                              Pin xnor_in0_pin, string xnor_in0_val,
                              Pin xnor_in1_pin, string xnor_in1_val,
                              Pin xnor_out_pin, string xnor_out_val,
                              Pin xor_in0_pin, string xor_in0_val,
                              Pin xor_in1_pin, string xor_in1_val,
                              Pin xor_out_pin, string xor_out_val,
                              Pin y1_in_pin, string y1_in_val,
                              Logic y1_res_real, string y1_res_exp)
            {
                Require.That(x1_out_pin.State.Value == Logic.StringToLogicValue(x1_out_val));
                Require.That(x2_out_pin.State.Value == Logic.StringToLogicValue(x2_out_val));
                Require.That(x3_out_pin.State.Value == Logic.StringToLogicValue(x3_out_val));

                Require.That(xnor_in0_pin.State.Value == Logic.StringToLogicValue(xnor_in0_val));
                Require.That(xnor_in1_pin.State.Value == Logic.StringToLogicValue(xnor_in1_val));
                Require.That(xnor_out_pin.State.Value == Logic.StringToLogicValue(xnor_out_val));

                Require.That(xor_in0_pin.State.Value == Logic.StringToLogicValue(xor_in0_val));
                Require.That(xor_in1_pin.State.Value == Logic.StringToLogicValue(xor_in1_val));
                Require.That(xor_out_pin.State.Value == Logic.StringToLogicValue(xor_out_val));

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

            XNOR xnor = new XNOR();
            cir.AddElement(xnor);

            XOR xor = new XOR();
            cir.AddElement(xor);

            OutTerminal y1 = new OutTerminal();
            cir.AddElement(y1);

            Pin x1_out = x1.GetPin(PinSide.OUTPUT, 0);
            Pin x2_out = x2.GetPin(PinSide.OUTPUT, 0);
            Pin x3_out = x3.GetPin(PinSide.OUTPUT, 0);
            Pin xnor_in0 = xnor.GetPin(PinSide.INPUT, 0);
            Pin xnor_in1 = xnor.GetPin(PinSide.INPUT, 1);
            Pin xnor_out = xnor.GetPin(PinSide.OUTPUT, 0);
            Pin xor_in0 = xor.GetPin(PinSide.INPUT, 0);
            Pin xor_in1 = xor.GetPin(PinSide.INPUT, 1);
            Pin xor_out = xor.GetPin(PinSide.OUTPUT, 0);
            Pin y1_in = y1.GetPin(PinSide.INPUT, 0);

            cir.Connect(x1_out, xnor_in0);
            cir.Connect(x2_out, xnor_in1);
            cir.Connect(xnor_out, xor_in0);
            cir.Connect(x3_out, xor_in1);
            cir.Connect(xor_out, y1_in);

            x1.SimulationInputValue = new Logic(LogicValue.LOGIC_0);
            x2.SimulationInputValue = new Logic(LogicValue.LOGIC_0);
            x3.SimulationInputValue = new Logic(LogicValue.LOGIC_0);

            cir.RestartSimulation();
            VerifyStates(
                x1_out, "U", x2_out, "U", x3_out, "U",
                xnor_in0, "U", xnor_in1, "U", xnor_out, "U",
                xor_in0, "U", xor_in1, "U", xor_out, "U",
                y1_in, "U", y1.SimulationResult, "U");

            cir.NextMoment();
            VerifyStates(
               x1_out, "0", x2_out, "0", x3_out, "0",
               xnor_in0, "0", xnor_in1, "0", xnor_out, "U",
               xor_in0, "U", xor_in1, "0", xor_out, "U",
               y1_in, "U", y1.SimulationResult, "U");

            cir.NextMoment();
            VerifyStates(
               x1_out, "0", x2_out, "0", x3_out, "0",
               xnor_in0, "0", xnor_in1, "0", xnor_out, "1",
               xor_in0, "1", xor_in1, "0", xor_out, "U",
               y1_in, "U", y1.SimulationResult, "U");

            cir.NextMoment();
            VerifyStates(
               x1_out, "0", x2_out, "0", x3_out, "0",
               xnor_in0, "0", xnor_in1, "0", xnor_out, "1",
               xor_in0, "1", xor_in1, "0", xor_out, "1",
               y1_in, "1", y1.SimulationResult, "U");

            cir.NextMoment();
            VerifyStates(
               x1_out, "0", x2_out, "0", x3_out, "0",
               xnor_in0, "0", xnor_in1, "0", xnor_out, "1",
               xor_in0, "1", xor_in1, "0", xor_out, "1",
               y1_in, "1", y1.SimulationResult, "1");

            Console.WriteLine("TestCase_Xnor_Xor_GatesSimulation passed.");
        }

        public static void TestCase_Fork_3Not_And_GatesSimulation()
        {
            void VerifyStates(Pin x1_out_pin, string x1_out_val,
                              Pin fork_in_pin, string fork_in_val,
                              Pin fork_out0_pin, string fork_out0_val,
                              Pin fork_out1_pin, string fork_out1_val,

                              Pin not0_in_pin, string not0_in_val,
                              Pin not1_in_pin, string not1_in_val,
                              Pin not0_out_pin, string not0_out_val,
                              Pin not1_out_pin, string not1_out_val,

                              Pin and_in0_pin, string and_in0_val,
                              Pin and_in1_pin, string and_in1_val,
                              Pin and_out_pin, string and_out_val,

                              Pin not2_in_pin, string not2_in_val,
                              Pin not2_out_pin, string not2_out_val,

                              Pin y1_in_pin, string y1_in_val,
                              Logic y1_res_real, string y1_res_exp)
            {
                Require.That(x1_out_pin.State.Value == Logic.StringToLogicValue(x1_out_val));

                Require.That(fork_in_pin.State.Value == Logic.StringToLogicValue(fork_in_val));
                Require.That(fork_out0_pin.State.Value == Logic.StringToLogicValue(fork_out0_val));
                Require.That(fork_out1_pin.State.Value == Logic.StringToLogicValue(fork_out1_val));

                Require.That(not0_in_pin.State.Value == Logic.StringToLogicValue(not0_in_val));
                Require.That(not1_in_pin.State.Value == Logic.StringToLogicValue(not1_in_val));
                Require.That(not0_out_pin.State.Value == Logic.StringToLogicValue(not0_out_val));
                Require.That(not1_out_pin.State.Value == Logic.StringToLogicValue(not1_out_val));

                Require.That(and_in0_pin.State.Value == Logic.StringToLogicValue(and_in0_val));
                Require.That(and_in1_pin.State.Value == Logic.StringToLogicValue(and_in1_val));
                Require.That(and_out_pin.State.Value == Logic.StringToLogicValue(and_out_val));

                Require.That(not2_in_pin.State.Value == Logic.StringToLogicValue(not2_in_val));
                Require.That(not2_out_pin.State.Value == Logic.StringToLogicValue(not2_out_val));

                Require.That(y1_in_pin.State.Value == Logic.StringToLogicValue(y1_in_val));
                Require.That(y1_res_real.Value == Logic.StringToLogicValue(y1_res_exp));
            }

            Circuit cir = new Circuit();
            InTerminal x1 = new InTerminal();
            cir.AddElement(x1);

            FORK fork = new FORK();
            cir.AddElement(fork);

            AND and = new AND();
            cir.AddElement(and);

            NOT not0 = new NOT();
            cir.AddElement(not0);

            NOT not1 = new NOT();
            cir.AddElement(not1);

            NOT not2 = new NOT();
            cir.AddElement(not2);

            OutTerminal y1 = new OutTerminal();
            cir.AddElement(y1);

            Pin x1_out = x1.GetPin(PinSide.OUTPUT, 0);

            Pin fork_in = fork.GetPin(PinSide.INPUT, 0);
            Pin fork_out0 = fork.GetPin(PinSide.OUTPUT, 0);
            Pin fork_out1 = fork.GetPin(PinSide.OUTPUT, 1);

            Pin not0_in = not0.GetPin(PinSide.INPUT, 0);
            Pin not1_in = not1.GetPin(PinSide.INPUT, 0);
            Pin not0_out = not0.GetPin(PinSide.OUTPUT, 0);
            Pin not1_out = not1.GetPin(PinSide.OUTPUT, 0);

            Pin and_in0 = and.GetPin(PinSide.INPUT, 0);
            Pin and_in1 = and.GetPin(PinSide.INPUT, 1);
            Pin and_out = and.GetPin(PinSide.OUTPUT, 0);

            Pin not2_in = not2.GetPin(PinSide.INPUT, 0);
            Pin not2_out = not2.GetPin(PinSide.OUTPUT, 0);

            Pin y1_in = y1.GetPin(PinSide.INPUT, 0);

            cir.Connect(x1_out, fork_in);
            cir.Connect(fork_out0, not0_in);
            cir.Connect(fork_out1, not1_in);
            cir.Connect(not0_out, and_in0);
            cir.Connect(not1_out, and_in1);
            cir.Connect(and_out, not2_in);
            cir.Connect(not2_out, y1_in);

            x1.SimulationInputValue = new Logic(LogicValue.LOGIC_1);

            cir.RestartSimulation();
            VerifyStates(
                x1_out, "U", fork_in, "U", fork_out0, "U", fork_out1, "U", 
                not0_in, "U", not0_out, "U", not1_in, "U", not1_out, "U",
                and_in0, "U", and_in1, "U", and_out, "U",
                not2_in, "U", not2_out, "U", y1_in, "U", y1.SimulationResult, "U");

            cir.NextMoment();
            VerifyStates(
                x1_out, "1", fork_in, "1", fork_out0, "U", fork_out1, "U",
                not0_in, "U", not0_out, "U", not1_in, "U", not1_out, "U",
                and_in0, "U", and_in1, "U", and_out, "U",
                not2_in, "U", not2_out, "U", y1_in, "U", y1.SimulationResult, "U");

            cir.NextMoment();
            VerifyStates(
                x1_out, "1", fork_in, "1", fork_out0, "1", fork_out1, "1",
                not0_in, "1", not0_out, "U", not1_in, "1", not1_out, "U",
                and_in0, "U", and_in1, "U", and_out, "U",
                not2_in, "U", not2_out, "U", y1_in, "U", y1.SimulationResult, "U");

            cir.NextMoment();
            VerifyStates(
                x1_out, "1", fork_in, "1", fork_out0, "1", fork_out1, "1",
                not0_in, "1", not0_out, "0", not1_in, "1", not1_out, "0",
                and_in0, "0", and_in1, "0", and_out, "U",
                not2_in, "U", not2_out, "U", y1_in, "U", y1.SimulationResult, "U");

            cir.NextMoment();
            VerifyStates(
                x1_out, "1", fork_in, "1", fork_out0, "1", fork_out1, "1",
                not0_in, "1", not0_out, "0", not1_in, "1", not1_out, "0",
                and_in0, "0", and_in1, "0", and_out, "0",
                not2_in, "0", not2_out, "U", y1_in, "U", y1.SimulationResult, "U");

            cir.NextMoment();
            VerifyStates(
                x1_out, "1", fork_in, "1", fork_out0, "1", fork_out1, "1",
                not0_in, "1", not0_out, "0", not1_in, "1", not1_out, "0",
                and_in0, "0", and_in1, "0", and_out, "0",
                not2_in, "0", not2_out, "1", y1_in, "1", y1.SimulationResult, "U");

            cir.NextMoment();
            VerifyStates(
                x1_out, "1", fork_in, "1", fork_out0, "1", fork_out1, "1",
                not0_in, "1", not0_out, "0", not1_in, "1", not1_out, "0",
                and_in0, "0", and_in1, "0", and_out, "0",
                not2_in, "0", not2_out, "1", y1_in, "1", y1.SimulationResult, "1");

            Console.WriteLine("TestCase_Fork_3Not_And_GatesSimulation passed.");
        }

        public static void TestCase_SetNumberOfInputPinsAnd()
        {
            Circuit c = new Circuit();
            AND and = new AND();
            c.AddElement(and);
            Pin and_in0 = and.GetPin(PinSide.INPUT, 0);
            Pin and_in1 = and.GetPin(PinSide.INPUT, 1);
            Require.That(and.GetNumberOfPins(PinSide.INPUT) == 2);
            Require.That(and.GetNumberOfPins(PinSide.OUTPUT) == 1);

            InTerminal x1 = new InTerminal();
            InTerminal x2 = new InTerminal();
            c.AddElement(x1);
            c.AddElement(x2);
            Pin x1_out = x1.GetPin(PinSide.OUTPUT, 0);
            Pin x2_out = x2.GetPin(PinSide.OUTPUT, 0);

            c.Connect(x1_out, and_in0);
            Require.That(and_in0.ConnectedPin == x1_out);
            Require.That(x1_out.ConnectedPin == and_in0);
            Require.That(and_in1.ConnectedPin == null);

            c.SetNumberOfInputPins(and, 5);
            Require.That(and.GetNumberOfPins(PinSide.INPUT) == 5);
            Require.That(and.GetNumberOfPins(PinSide.OUTPUT) == 1);
            Require.That(and_in0.ConnectedPin == x1_out);
            Require.That(x1_out.ConnectedPin == and_in0);
            for (byte i = 1; i < 5; i++)
            {
                Require.That(and.GetPin(PinSide.INPUT, i).ConnectedPin == null);
            }

            Pin and_in4 = and.GetPin(PinSide.INPUT, 4);
            c.Connect(x2_out, and_in4);
            Require.That(and_in4.ConnectedPin == x2_out);
            Require.That(x2_out.ConnectedPin == and_in4);

            c.SetNumberOfInputPins(and, 3);
            Require.That(and.GetNumberOfPins(PinSide.INPUT) == 3);
            Require.That(and_in0.ConnectedPin != null);
            Require.That(x2_out.ConnectedPin == null);
            for (byte i = 1; i < 3; i++)
            {
                Require.That(and.GetPin(PinSide.INPUT, i).ConnectedPin == null);
            }
            c.Disconnect(and_in0);
            Require.That(x1_out.ConnectedPin == null);
            Require.That(and_in0.ConnectedPin == null);

            c.RemoveElement(and);
            Console.WriteLine("TestCase_SetNumberOfInputPinsAnd passed.");
        }

        public static void TestCase_6AndGateSimulation()
        {
            void VerifyStates(Pin x1_out_pin, string x1_out_val,
                              Pin x2_out_pin, string x2_out_val,
                              Pin x3_out_pin, string x3_out_val,
                              Pin x4_out_pin, string x4_out_val,
                              Pin x5_out_pin, string x5_out_val,
                              Pin x6_out_pin, string x6_out_val,

                              Pin and_in0_pin, string and_in0_val,
                              Pin and_in1_pin, string and_in1_val,
                              Pin and_in2_pin, string and_in2_val,
                              Pin and_in3_pin, string and_in3_val,
                              Pin and_in4_pin, string and_in4_val,
                              Pin and_in5_pin, string and_in5_val,
                              Pin and_out_pin, string and_out_val,

                              Pin y1_in_pin, string y1_in_val,
                              Logic y1_res_real, string y1_res_exp)
            {
                Require.That(x1_out_pin.State.Value == Logic.StringToLogicValue(x1_out_val));
                Require.That(x2_out_pin.State.Value == Logic.StringToLogicValue(x2_out_val));
                Require.That(x3_out_pin.State.Value == Logic.StringToLogicValue(x3_out_val));
                Require.That(x4_out_pin.State.Value == Logic.StringToLogicValue(x4_out_val));
                Require.That(x5_out_pin.State.Value == Logic.StringToLogicValue(x5_out_val));
                Require.That(x6_out_pin.State.Value == Logic.StringToLogicValue(x6_out_val));

                Require.That(and_in0_pin.State.Value == Logic.StringToLogicValue(and_in0_val));
                Require.That(and_in1_pin.State.Value == Logic.StringToLogicValue(and_in1_val));
                Require.That(and_in2_pin.State.Value == Logic.StringToLogicValue(and_in2_val));
                Require.That(and_in3_pin.State.Value == Logic.StringToLogicValue(and_in3_val));
                Require.That(and_in4_pin.State.Value == Logic.StringToLogicValue(and_in4_val));
                Require.That(and_in5_pin.State.Value == Logic.StringToLogicValue(and_in5_val));
                Require.That(and_out_pin.State.Value == Logic.StringToLogicValue(and_out_val));

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
            InTerminal x4 = new InTerminal();
            cir.AddElement(x4);
            InTerminal x5 = new InTerminal();
            cir.AddElement(x5);
            InTerminal x6 = new InTerminal();
            cir.AddElement(x6);

            AND and = new AND();
            cir.AddElement(and);
            cir.SetNumberOfInputPins(and, 6);
            for(byte i = 1; i<6; i++)
            {
                Require.That(and.GetPin(PinSide.INPUT, i).ConnectedPin == null);
            }

            OutTerminal y1 = new OutTerminal();
            cir.AddElement(y1);

            Pin x1_out = x1.GetPin(PinSide.OUTPUT, 0);
            Pin x2_out = x2.GetPin(PinSide.OUTPUT, 0);
            Pin x3_out = x3.GetPin(PinSide.OUTPUT, 0);
            Pin x4_out = x4.GetPin(PinSide.OUTPUT, 0);
            Pin x5_out = x5.GetPin(PinSide.OUTPUT, 0);
            Pin x6_out = x6.GetPin(PinSide.OUTPUT, 0);

            Pin and_in0 = and.GetPin(PinSide.INPUT, 0);
            Pin and_in1 = and.GetPin(PinSide.INPUT, 1);
            Pin and_in2 = and.GetPin(PinSide.INPUT, 2);
            Pin and_in3 = and.GetPin(PinSide.INPUT, 3);
            Pin and_in4 = and.GetPin(PinSide.INPUT, 4);
            Pin and_in5 = and.GetPin(PinSide.INPUT, 5);
            Pin and_out = and.GetPin(PinSide.OUTPUT, 0);
            Pin y1_in = y1.GetPin(PinSide.INPUT, 0);

            cir.Connect(x1_out, and_in0);
            cir.Connect(x2_out, and_in1);
            cir.Connect(x3_out, and_in2);
            cir.Connect(x4_out, and_in3);
            cir.Connect(x5_out, and_in4);
            cir.Connect(x6_out, and_in5);
            cir.Connect(and_out, y1_in);

            x1.SimulationInputValue = new Logic(LogicValue.LOGIC_1);
            x2.SimulationInputValue = new Logic(LogicValue.LOGIC_1);
            x3.SimulationInputValue = new Logic(LogicValue.LOGIC_1);
            x4.SimulationInputValue = new Logic(LogicValue.LOGIC_1);
            x5.SimulationInputValue = new Logic(LogicValue.LOGIC_1);
            x6.SimulationInputValue = new Logic(LogicValue.LOGIC_1);

            cir.RestartSimulation();
            VerifyStates(x1_out, "U", x2_out, "U", x3_out, "U", x4_out, "U", x5_out, "U", x6_out, "U",
                and_in0, "U", and_in1,"U" , and_in2, "U", and_in3, "U", and_in4, "U", and_in5, "U", and_out, "U", 
                y1_in, "U", y1.SimulationResult, "U");

            cir.NextMoment();
            VerifyStates(x1_out, "1", x2_out, "1", x3_out, "1", x4_out, "1", x5_out, "1", x6_out, "1",
                and_in0, "1", and_in1, "1", and_in2, "1", and_in3, "1", and_in4, "1", and_in5, "1", and_out, "U",
                y1_in, "U", y1.SimulationResult, "U");

            cir.NextMoment();
            VerifyStates(x1_out, "1", x2_out, "1", x3_out, "1", x4_out, "1", x5_out, "1", x6_out, "1",
                and_in0, "1", and_in1, "1", and_in2, "1", and_in3, "1", and_in4, "1", and_in5, "1", and_out, "1",
                y1_in, "1", y1.SimulationResult, "U");

            cir.NextMoment();
            VerifyStates(x1_out, "1", x2_out, "1", x3_out, "1", x4_out, "1", x5_out, "1", x6_out, "1",
                and_in0, "1", and_in1, "1", and_in2, "1", and_in3, "1", and_in4, "1", and_in5, "1", and_out, "1",
                y1_in, "1", y1.SimulationResult, "1");
            Console.WriteLine("TestCase_6AndGateSimulation passed.");
        }

        public static void TestCase_ConnectDisconnectOfNot()
        {
            Circuit c = new Circuit();
            NOT not = new NOT();
            c.AddElement(not);
            Pin not_in = not.GetPin(PinSide.INPUT, 0);
            Pin not_out = not.GetPin(PinSide.OUTPUT, 0);
            Require.That(not.GetNumberOfPins(PinSide.INPUT) == 1);
            Require.That(not.GetNumberOfPins(PinSide.OUTPUT) == 1);

            InTerminal x1 = new InTerminal();
            c.AddElement(x1);
            Pin x1_out = x1.GetPin(PinSide.OUTPUT, 0);

            c.Connect(x1_out, not_in);
            Require.That(not_in.ConnectedPin == x1_out);
            Require.That(x1_out.ConnectedPin == not_in);
            
            c.Disconnect(not_in);
            Require.That(x1_out.ConnectedPin == null);
            Require.That(not_in.ConnectedPin == null);

            c.RemoveElement(not);
            Console.WriteLine("TestCase_ConnectDisconnectOfNot passed.");
        }

        public static void TestCase_SetNumberOfInputPinsNand()
        {
            Circuit c = new Circuit();
            NAND nand = new NAND();
            c.AddElement(nand);
            Pin nand_in0 = nand.GetPin(PinSide.INPUT, 0);
            Pin nand_in1 = nand.GetPin(PinSide.INPUT, 1);
            Require.That(nand.GetNumberOfPins(PinSide.INPUT) == 2);
            Require.That(nand.GetNumberOfPins(PinSide.OUTPUT) == 1);

            InTerminal x1 = new InTerminal();
            InTerminal x2 = new InTerminal();
            c.AddElement(x1);
            c.AddElement(x2);
            Pin x1_out = x1.GetPin(PinSide.OUTPUT, 0);
            Pin x2_out = x2.GetPin(PinSide.OUTPUT, 0);

            c.Connect(x1_out, nand_in0);
            Require.That(nand_in0.ConnectedPin == x1_out);
            Require.That(x1_out.ConnectedPin == nand_in0);
            Require.That(nand_in1.ConnectedPin == null);

            c.SetNumberOfInputPins(nand, 8);
            Require.That(nand.GetNumberOfPins(PinSide.INPUT) == 8);
            Require.That(nand.GetNumberOfPins(PinSide.OUTPUT) == 1);
            Require.That(nand_in0.ConnectedPin == x1_out);
            Require.That(x1_out.ConnectedPin == nand_in0);
            for (byte i = 1; i < 8; i++)
            {
                Require.That(nand.GetPin(PinSide.INPUT, i).ConnectedPin == null);
            }

            Pin nand_in6 = nand.GetPin(PinSide.INPUT, 6);
            c.Connect(x2_out, nand_in6);
            Require.That(nand_in6.ConnectedPin == x2_out);
            Require.That(x2_out.ConnectedPin == nand_in6);
            for (byte i = 1; i < 6; i++)
            {
                Require.That(nand.GetPin(PinSide.INPUT, i).ConnectedPin == null);
            }
            Require.That(nand.GetPin(PinSide.INPUT, 7).ConnectedPin == null);

            c.SetNumberOfInputPins(nand, 5);
            Require.That(nand.GetNumberOfPins(PinSide.INPUT) == 5);
            Require.That(nand_in0.ConnectedPin != null);
            Require.That(x2_out.ConnectedPin == null);
            for (byte i = 1; i < 5; i++)
            {
                Require.That(nand.GetPin(PinSide.INPUT, i).ConnectedPin == null);
            }
            c.Disconnect(nand_in0);
            Require.That(x1_out.ConnectedPin == null);
            Require.That(nand_in0.ConnectedPin == null);

            c.RemoveElement(nand);
            Console.WriteLine("TestCase_SetNumberOfInputPinsNand passed.");
        }

        public static void TestCase_8NandGateSimulation()
        {
            void VerifyStates(Pin x1_out_pin, string x1_out_val,
                              Pin x2_out_pin, string x2_out_val,
                              Pin x3_out_pin, string x3_out_val,
                              Pin x4_out_pin, string x4_out_val,
                              Pin x5_out_pin, string x5_out_val,
                              Pin x6_out_pin, string x6_out_val,
                              Pin x7_out_pin, string x7_out_val,
                              Pin x8_out_pin, string x8_out_val,

                              Pin nand_in0_pin, string nand_in0_val,
                              Pin nand_in1_pin, string nand_in1_val,
                              Pin nand_in2_pin, string nand_in2_val,
                              Pin nand_in3_pin, string nand_in3_val,
                              Pin nand_in4_pin, string nand_in4_val,
                              Pin nand_in5_pin, string nand_in5_val,
                              Pin nand_in6_pin, string nand_in6_val,
                              Pin nand_in7_pin, string nand_in7_val,
                              Pin nand_out_pin, string nand_out_val,

                              Pin y1_in_pin, string y1_in_val,
                              Logic y1_res_real, string y1_res_exp)
            {
                Require.That(x1_out_pin.State.Value == Logic.StringToLogicValue(x1_out_val));
                Require.That(x2_out_pin.State.Value == Logic.StringToLogicValue(x2_out_val));
                Require.That(x3_out_pin.State.Value == Logic.StringToLogicValue(x3_out_val));
                Require.That(x4_out_pin.State.Value == Logic.StringToLogicValue(x4_out_val));
                Require.That(x5_out_pin.State.Value == Logic.StringToLogicValue(x5_out_val));
                Require.That(x6_out_pin.State.Value == Logic.StringToLogicValue(x6_out_val));
                Require.That(x7_out_pin.State.Value == Logic.StringToLogicValue(x7_out_val));
                Require.That(x8_out_pin.State.Value == Logic.StringToLogicValue(x8_out_val));

                Require.That(nand_in0_pin.State.Value == Logic.StringToLogicValue(nand_in0_val));
                Require.That(nand_in1_pin.State.Value == Logic.StringToLogicValue(nand_in1_val));
                Require.That(nand_in2_pin.State.Value == Logic.StringToLogicValue(nand_in2_val));
                Require.That(nand_in3_pin.State.Value == Logic.StringToLogicValue(nand_in3_val));
                Require.That(nand_in4_pin.State.Value == Logic.StringToLogicValue(nand_in4_val));
                Require.That(nand_in5_pin.State.Value == Logic.StringToLogicValue(nand_in5_val));
                Require.That(nand_in6_pin.State.Value == Logic.StringToLogicValue(nand_in6_val));
                Require.That(nand_in7_pin.State.Value == Logic.StringToLogicValue(nand_in7_val));
                Require.That(nand_out_pin.State.Value == Logic.StringToLogicValue(nand_out_val));

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
            InTerminal x4 = new InTerminal();
            cir.AddElement(x4);
            InTerminal x5 = new InTerminal();
            cir.AddElement(x5);
            InTerminal x6 = new InTerminal();
            cir.AddElement(x6);
            InTerminal x7 = new InTerminal();
            cir.AddElement(x7);
            InTerminal x8 = new InTerminal();
            cir.AddElement(x8);

            NAND nand = new NAND();
            cir.AddElement(nand);
            cir.SetNumberOfInputPins(nand, 8);
            for (byte i = 1; i < 8; i++)
            {
                Require.That(nand.GetPin(PinSide.INPUT, i).ConnectedPin == null);
            }

            OutTerminal y1 = new OutTerminal();
            cir.AddElement(y1);

            Pin x1_out = x1.GetPin(PinSide.OUTPUT, 0);
            Pin x2_out = x2.GetPin(PinSide.OUTPUT, 0);
            Pin x3_out = x3.GetPin(PinSide.OUTPUT, 0);
            Pin x4_out = x4.GetPin(PinSide.OUTPUT, 0);
            Pin x5_out = x5.GetPin(PinSide.OUTPUT, 0);
            Pin x6_out = x6.GetPin(PinSide.OUTPUT, 0);
            Pin x7_out = x7.GetPin(PinSide.OUTPUT, 0);
            Pin x8_out = x8.GetPin(PinSide.OUTPUT, 0);

            Pin nand_in0 = nand.GetPin(PinSide.INPUT, 0);
            Pin nand_in1 = nand.GetPin(PinSide.INPUT, 1);
            Pin nand_in2 = nand.GetPin(PinSide.INPUT, 2);
            Pin nand_in3 = nand.GetPin(PinSide.INPUT, 3);
            Pin nand_in4 = nand.GetPin(PinSide.INPUT, 4);
            Pin nand_in5 = nand.GetPin(PinSide.INPUT, 5);
            Pin nand_in6 = nand.GetPin(PinSide.INPUT, 6);
            Pin nand_in7 = nand.GetPin(PinSide.INPUT, 7);
            Pin nand_out = nand.GetPin(PinSide.OUTPUT, 0);
            Pin y1_in = y1.GetPin(PinSide.INPUT, 0);

            cir.Connect(x1_out, nand_in0);
            Require.That(x1_out.ConnectedPin == nand_in0);
            Require.That(nand_in0.ConnectedPin == x1_out);
            cir.Connect(x2_out, nand_in1);
            Require.That(x2_out.ConnectedPin == nand_in1);
            Require.That(nand_in1.ConnectedPin == x2_out);
            cir.Connect(x3_out, nand_in2);
            Require.That(x3_out.ConnectedPin == nand_in2);
            Require.That(nand_in2.ConnectedPin == x3_out);
            cir.Connect(x4_out, nand_in3);
            Require.That(x4_out.ConnectedPin == nand_in3);
            Require.That(nand_in3.ConnectedPin == x4_out);
            cir.Connect(x5_out, nand_in4);
            Require.That(x5_out.ConnectedPin == nand_in4);
            Require.That(nand_in4.ConnectedPin == x5_out);
            cir.Connect(x6_out, nand_in5);
            Require.That(x6_out.ConnectedPin == nand_in5);
            Require.That(nand_in5.ConnectedPin == x6_out);
            cir.Connect(x7_out, nand_in6);
            Require.That(x7_out.ConnectedPin == nand_in6);
            Require.That(nand_in6.ConnectedPin == x7_out);
            cir.Connect(x8_out, nand_in7);
            Require.That(x8_out.ConnectedPin == nand_in7);
            Require.That(nand_in7.ConnectedPin == x8_out);
            cir.Connect(nand_out, y1_in);

            x1.SimulationInputValue = new Logic(LogicValue.LOGIC_0);
            x2.SimulationInputValue = new Logic(LogicValue.LOGIC_0);
            x3.SimulationInputValue = new Logic(LogicValue.LOGIC_0);
            x4.SimulationInputValue = new Logic(LogicValue.LOGIC_0);
            x5.SimulationInputValue = new Logic(LogicValue.LOGIC_0);
            x6.SimulationInputValue = new Logic(LogicValue.LOGIC_0);
            x6.SimulationInputValue = new Logic(LogicValue.LOGIC_0);
            x7.SimulationInputValue = new Logic(LogicValue.LOGIC_0);
            x8.SimulationInputValue = new Logic(LogicValue.LOGIC_0);

            cir.RestartSimulation();
            VerifyStates(x1_out, "U", x2_out, "U", x3_out, "U", x4_out, "U", x5_out, "U", x6_out, "U", x7_out, "U", x8_out, "U",
                nand_in0, "U", nand_in1, "U", nand_in2, "U", nand_in3, "U", nand_in4, "U", nand_in5, "U", nand_in6, "U", nand_in7, "U", nand_out, "U",
                y1_in, "U", y1.SimulationResult, "U");

            cir.NextMoment();
            VerifyStates(x1_out, "0", x2_out, "0", x3_out, "0", x4_out, "0", x5_out, "0", x6_out, "0", x7_out, "0", x8_out, "0",
                nand_in0, "0", nand_in1, "0", nand_in2, "0", nand_in3, "0", nand_in4, "0", nand_in5, "0", nand_in6, "0", nand_in7, "0", nand_out, "U",
                y1_in, "U", y1.SimulationResult, "U");

            cir.NextMoment();
            VerifyStates(x1_out, "0", x2_out, "0", x3_out, "0", x4_out, "0", x5_out, "0", x6_out, "0", x7_out, "0", x8_out, "0",
                nand_in0, "0", nand_in1, "0", nand_in2, "0", nand_in3, "0", nand_in4, "0", nand_in5, "0", nand_in6, "0", nand_in7, "0", nand_out, "1",
                y1_in, "1", y1.SimulationResult, "U");

            cir.NextMoment();
            VerifyStates(x1_out, "0", x2_out, "0", x3_out, "0", x4_out, "0", x5_out, "0", x6_out, "0", x7_out, "0", x8_out, "0",
                 nand_in0, "0", nand_in1, "0", nand_in2, "0", nand_in3, "0", nand_in4, "0", nand_in5, "0", nand_in6, "0", nand_in7, "0", nand_out, "1",
                 y1_in, "1", y1.SimulationResult, "1");
            Console.WriteLine("TestCase_8NandGateSimulation passed.");
        }
    }
}
