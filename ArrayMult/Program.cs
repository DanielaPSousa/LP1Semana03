using System;

namespace ArrayMult
{
    class Program
    {
        static void Main(string[] args)
        {
            using System;

namespace ArrayMult
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write 6 numbers:");

            float arg1 = float.Parse(args[0]);
            float arg2 = float.Parse(args[1]);
            float arg3 = float.Parse(args[2]);
            float arg4 = float.Parse(args[3]);
            float arg5 = float.Parse(args[4]);
            float arg6 = float.Parse(args[5]);

            float[,] A = { { arg1, arg2 }, { arg3, arg4 } };
            float[] b = { arg5, arg6 };

            float[] result = MultiplyMatrixByVector(A, b);

            Console.WriteLine($"{result[0]}");
            Console.WriteLine($"{result[1]}");
        }

    }
}

        }
    }
}
