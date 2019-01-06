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
            Console.WriteLine("U AND U passed.");

            //U AND 0
            result = U & l_0;
            Require.That(result.Value == LogicValue.LOGIC_0, "Result of U AND 0 isn't 0.");
            Console.WriteLine("U AND 0 passed.");

            //U AND 1
            result = U & l_1;
            Require.That(result.Value == LogicValue.UNINITIALIZED, "Result of U AND 1 isn't U.");
            Console.WriteLine("U AND 1 passed.");

            //0 AND U
            result = l_0 & U;
            Require.That(result.Value == LogicValue.LOGIC_0, "Result of 0 AND U isn't 0.");
            Console.WriteLine("0 AND U passed.");

            //0 AND 0
            result = l_0 & l_0;
            Require.That(result.Value == LogicValue.LOGIC_0, "Result of 0 AND 0 isn't 0.");
            Console.WriteLine("0 AND 0 passed.");

            //0 AND 1
            result = l_0 & l_1;
            Require.That(result.Value == LogicValue.LOGIC_0, "Result of 0 AND 1 isn't 0.");
            Console.WriteLine("0 AND 1 passed.");

            //1 AND U
            result = l_1 & U;
            Require.That(result.Value == LogicValue.UNINITIALIZED, "Result of 1 AND U isn't U.");
            Console.WriteLine("1 AND U passed.");

            //1 AND 0
            result = l_1 & l_0;
            Require.That(result.Value == LogicValue.LOGIC_0, "Result of 1 AND 0 isn't 0.");
            Console.WriteLine("1 AND 0 passed.");

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
            Console.WriteLine("U OR U passed.");

            //U OR 0
            result = U | l_0;
            Require.That(result.Value == LogicValue.UNINITIALIZED, "Result of U OR 0 isn't U.");
            Console.WriteLine("U OR 0 passed.");

            //U OR 1
            result = U | l_1;
            Require.That(result.Value == LogicValue.LOGIC_1, "Result of U OR 1 isn't 1.");
            Console.WriteLine("U OR 1 passed.");

            //0 OR U
            result = l_0 | U;
            Require.That(result.Value == LogicValue.UNINITIALIZED, "Result of 0 OR U isn't U.");
            Console.WriteLine("0 OR U passed.");

            //0 OR 0
            result = l_0 | l_0;
            Require.That(result.Value == LogicValue.LOGIC_0, "Result of 0 OR 0 isn't 0.");
            Console.WriteLine("0 OR 0 passed.");

            //0 OR 1
            result = l_0 | l_1;
            Require.That(result.Value == LogicValue.LOGIC_1, "Result of 0 OR 1 isn't 1.");
            Console.WriteLine("0 OR 1 passed.");

            //1 OR U
            result = l_1 | U;
            Require.That(result.Value == LogicValue.LOGIC_1, "Result of 1 OR U isn't 1.");
            Console.WriteLine("1 OR U passed.");

            //1 OR 0
            result = l_1 | l_0;
            Require.That(result.Value == LogicValue.LOGIC_1, "Result of 1 OR 0 isn't 1.");
            Console.WriteLine("1 OR 0 passed.");

            //1 OR 1
            result = l_1 | l_1;
            Require.That(result.Value == LogicValue.LOGIC_1, "Result of 1 OR 1 isn't 1.");
            Console.WriteLine("1 OR 1 passed.");
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
            Console.WriteLine("U XOR U passed.");

            //U XOR 0
            result = U ^ l_0;
            Require.That(result.Value == LogicValue.UNINITIALIZED, "Result of U XOR 0 isn't U.");
            Console.WriteLine("U XOR 0 passed.");

            //U XOR 1
            result = U ^ l_1;
            Require.That(result.Value == LogicValue.UNINITIALIZED, "Result of U XOR 1 isn't U.");
            Console.WriteLine("U XOR 1 passed.");

            //0 XOR U
            result = l_0 ^ U;
            Require.That(result.Value == LogicValue.UNINITIALIZED, "Result of 0 XOR U isn't U.");
            Console.WriteLine("0 XOR U passed.");

            //0 XOR 0
            result = l_0 ^ l_0;
            Require.That(result.Value == LogicValue.LOGIC_0, "Result of 0 XOR 0 isn't 0.");
            Console.WriteLine("0 XOR 0 passed.");

            //0 XOR 1
            result = l_0 ^ l_1;
            Require.That(result.Value == LogicValue.LOGIC_1, "Result of 0 XOR 1 isn't 1.");
            Console.WriteLine("0 XOR 1 passed.");

            //1 XOR U
            result = l_1 ^ U;
            Require.That(result.Value == LogicValue.UNINITIALIZED, "Result of 1 XOR U isn't U.");
            Console.WriteLine("1 XOR U passed.");

            //1 XOR 0
            result = l_1 ^ l_0;
            Require.That(result.Value == LogicValue.LOGIC_1, "Result of 1 XOR 0 isn't 1.");
            Console.WriteLine("1 XOR 0 passed.");

            //1 XOR 1
            result = l_1 ^ l_1;
            Require.That(result.Value == LogicValue.LOGIC_0, "Result of 1 XOR 1 isn't 0.");
            Console.WriteLine("1 XOR 1 passed.");
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
            Console.WriteLine("NOT U passed.");

            //NOT 0
            result = !l_0;
            Require.That(result.Value == LogicValue.LOGIC_1, "Result of NOT 0 isn't 1.");
            Console.WriteLine("NOT 0 passed.");

            //NOT 1
            result = !l_1;
            Require.That(result.Value == LogicValue.LOGIC_0, "Result of NOT 1 isn't 0.");
            Console.WriteLine("NOT 1 passed.");
        }
    }
}
