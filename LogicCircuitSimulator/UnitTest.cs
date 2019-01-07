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
    }
}
