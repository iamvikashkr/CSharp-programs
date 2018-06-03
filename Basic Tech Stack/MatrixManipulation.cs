using System;

namespace Basic_Tech_Stack
{
    internal class MatrixManipulation
    {
        /// <summary>
        /// Function to perform matrix addition of two 2D arrays.
        /// </summary>
        public void addition()
        {
            try
            {

                Console.WriteLine(" Enter number of rows and column");
                int intRow = Convert.ToInt32(Console.ReadLine());
                int intCol = Convert.ToInt32(Console.ReadLine());

                int[,] intA = new int[intRow, intCol];
                int[,] intB = new int[intRow, intCol];

                Console.WriteLine("Enter the Matrix A elements");

                for (int i = 0; i < intRow; i++)
                {
                    for (int j = 0; j < intCol; j++)
                    {

                        intA[i, j] = Convert.ToInt16(Console.ReadLine());
                    }

                }



                Console.WriteLine("Matrix A is:");
                for (int i = 0; i < intRow; i++)
                {
                    for (int j = 0; j < intCol; j++)
                    {
                        Console.Write(intA[i, j] + "\t");

                    }
                    Console.WriteLine();
                }

                Console.WriteLine("Enter the Matrix B elements");

                for (int i = 0; i < intRow; i++)
                {
                    for (int j = 0; j < intCol; j++)
                    {

                        intB[i, j] = Convert.ToInt16(Console.ReadLine());
                    }

                }



                Console.WriteLine("Matrix B is:");
                for (int i = 0; i < intRow; i++)
                {
                    for (int j = 0; j < intCol; j++)
                    {
                        Console.Write(intB[i, j] + "\t");

                    }
                    Console.WriteLine();
                }
                int[,] intSum = new int[intA.Length, intB.Length];


                // Console.WriteLine(intA.Length);
                //Console.WriteLine(intB.Length);
                for (int i = 0; i < intRow; i++)
                {
                    for (int j = 0; j < intCol; j++)
                    {
                        try
                        {
                            intSum[i, j] = intA[i, j] + intB[i, j];
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message + " ");
                        }
                    }
                }

                Console.WriteLine("Sum of Two Matrix is:");
                for (int i = 0; i < intRow; i++)
                {
                    for (int j = 0; j < intCol; j++)
                    {
                        Console.Write(intSum[i, j] + "\t");

                    }
                    Console.WriteLine();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message + "");
            }
        }
        /// <summary>
        ///  Function to perform matrix subtraction of two 2D arrays.
        /// </summary>
        public void subtraction()
        {
            try
            {

                Console.WriteLine(" Enter number of rows and column");
                int intRow = Convert.ToInt32(Console.ReadLine());
                int intCol = Convert.ToInt32(Console.ReadLine());

                int[,] intA = new int[intRow, intCol];
                int[,] intB = new int[intRow, intCol];

                Console.WriteLine("Enter the Matrix A elements");

                for (int i = 0; i < intRow; i++)
                {
                    for (int j = 0; j < intCol; j++)
                    {

                        intA[i, j] = Convert.ToInt16(Console.ReadLine());
                    }

                }



                Console.WriteLine("Matrix A is:");
                for (int i = 0; i < intRow; i++)
                {
                    for (int j = 0; j < intCol; j++)
                    {
                        Console.Write(intA[i, j] + "\t");

                    }
                    Console.WriteLine();
                }

                Console.WriteLine("Enter the Matrix B elements");

                for (int i = 0; i < intRow; i++)
                {
                    for (int j = 0; j < intCol; j++)
                    {

                        intB[i, j] = Convert.ToInt16(Console.ReadLine());
                    }

                }



                Console.WriteLine("Matrix B is:");
                for (int i = 0; i < intRow; i++)
                {
                    for (int j = 0; j < intCol; j++)
                    {
                        Console.Write(intB[i, j] + "\t");

                    }
                    Console.WriteLine();
                }
                int[,] intSum = new int[intA.Length, intB.Length];


                // Console.WriteLine(intA.Length);
                //Console.WriteLine(intB.Length);
                for (int i = 0; i < intRow; i++)
                {
                    for (int j = 0; j < intCol; j++)
                    {
                        try
                        {
                            intSum[i, j] = intA[i, j] - intB[i, j];
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Error");
                        }
                    }
                }

                Console.WriteLine("Subtraction of Two Matrix is:");
                for (int i = 0; i < intRow; i++)
                {
                    for (int j = 0; j < intCol; j++)
                    {
                        Console.Write(intSum[i, j] + "\t");

                    }
                    Console.WriteLine();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message + "");
            }
        }
        /// <summary>
        ///  Function to perform matrix multiplication of two 2D arrays.
        /// </summary>
        public void multiplication()

        {
            try
            {

                Console.WriteLine(" Enter number of rows and column");
                int intRow = Convert.ToInt32(Console.ReadLine());
                int intCol = Convert.ToInt32(Console.ReadLine());

                int[,] intA = new int[intRow, intCol];
                int[,] intB = new int[intRow, intCol];

                Console.WriteLine("Enter the Matrix A elements");

                for (int i = 0; i < intRow; i++)
                {
                    for (int j = 0; j < intCol; j++)
                    {

                        intA[i, j] = Convert.ToInt16(Console.ReadLine());
                    }

                }



                Console.WriteLine("Matrix A is:");
                for (int i = 0; i < intRow; i++)
                {
                    for (int j = 0; j < intCol; j++)
                    {
                        Console.Write(intA[i, j] + "\t");

                    }
                    Console.WriteLine();
                }

                Console.WriteLine("Enter the Matrix B elements");

                for (int i = 0; i < intRow; i++)
                {
                    for (int j = 0; j < intCol; j++)
                    {

                        intB[i, j] = Convert.ToInt16(Console.ReadLine());
                    }

                }



                Console.WriteLine("Matrix B is:");
                for (int i = 0; i < intRow; i++)
                {
                    for (int j = 0; j < intCol; j++)
                    {
                        Console.Write(intB[i, j] + "\t");

                    }
                    Console.WriteLine();
                }
                int[,] intSum = new int[intA.Length, intB.Length];


                // Console.WriteLine(intA.Length);
                //Console.WriteLine(intB.Length);
                for (int i = 0; i < intRow; i++)
                {
                    for (int j = 0; j < intCol; j++)
                    {
                        try
                        {
                            intSum[i, j] = intA[i, j] * intB[i, j];
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Error");
                        }
                    }
                }

                Console.WriteLine("Multiplication of Two Matrix is:");
                for (int i = 0; i < intRow; i++)
                {
                    for (int j = 0; j < intCol; j++)
                    {
                        Console.Write(intSum[i, j] + "\t");

                    }
                    Console.WriteLine();
                }
            }

            catch (Exception e)
            {
                Console.WriteLine(e.Message + "");
            }


        }

        /// <summary>
        ///  Function to find inverse of two 2D arrays.
        /// </summary>
        public void inverse()
        {
            try
            {

                Console.WriteLine(" Enter number of rows and column");
                int intRow = Convert.ToInt32(Console.ReadLine());
                int intCol = Convert.ToInt32(Console.ReadLine());

                int[,] intA = new int[intRow, intCol];


                Console.WriteLine("Enter the Matrix A elements");

                for (int i = 0; i < intRow; i++)
                {
                    for (int j = 0; j < intCol; j++)
                    {

                        intA[i, j] = Convert.ToInt16(Console.ReadLine());
                    }

                }



                Console.WriteLine("Matrix A is:");
                for (int i = 0; i < intRow; i++)
                {
                    for (int j = 0; j < intCol; j++)
                    {
                        Console.Write(intA[i, j] + "\t");

                    }
                    Console.WriteLine();
                }

                int[,] adj = new int[intRow, intCol];
                adjoint(intA, adj);

                Console.WriteLine("Adjoint A is:");
                for (int i = 0; i < intRow; i++)
                {
                    for (int j = 0; j < intCol; j++)
                    {
                        Console.Write(adj[i, j] + "\t");

                    }
                    Console.WriteLine();
                }
                float[,] inv = new float[intRow, intCol];
                inverse(intA, inv);





            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message + "");
            }

        }

        private void inverse(int[,] intA, float[,] inv)
        {
            try
            {

                int N = intA.GetLength(0);
                int det = determinant(intA, N);


                int[,] adj = new int[N, N];
                adjoint(intA, adj);

                for (int i = 0; i < N; i++)
                    for (int j = 0; j < N; j++)
                        inv[i, j] = adj[i, j] / (float)(det);

                Console.WriteLine("Inverse A is:");
                for (int i = 0; i < N; i++)
                {
                    for (int j = 0; j < N; j++)
                    {
                        Console.Write(inv[i, j] + "\t");

                    }
                    Console.WriteLine();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }


        }

        public void adjoint(int[,] intA, int[,] adj)
        {
            try
            {

                int N = intA.GetLength(0);
                if (N == 1)
                {
                    adj[0, 0] = 1;
                    return;
                }
                int sign = 1;
                int[,] temp = new int[N, N];

                for (int i = 0; i < N; i++)
                {
                    for (int j = 0; j < N; j++)
                    {
                        // Get cofactor of A[i][j]
                        getCofactor(intA, temp, i, j, N);

                        // sign of adj[j][i] positive if sum of row
                        // and column indexes is even.
                        sign = ((i + j) % 2 == 0) ? 1 : -1;

                        // Interchanging rows and columns to get the
                        // transpose of the cofactor matrix
                        adj[j, i] = (sign) * (determinant(temp, N - 1));
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public int determinant(int[,] intA, int n)
        {



            int D = 0; // Initialize result

            //  Base case : if matrix contains single element
            if (n == 1)
                return intA[0, 0];
            int N = intA.GetLength(0);
            int[,] temp = new int[N, N]; // To store cofactors

            int sign = 1;  // To store sign multiplier

            // Iterate for each element of first row
            for (int f = 0; f < n; f++)
            {
                // Getting Cofactor of A[0][f]
                getCofactor(intA, temp, 0, f, n);
                D += sign * intA[0, f] * determinant(temp, n - 1);

                // terms are to be added with alternate sign
                sign = -sign;
            }

            return D;
        }



        public void getCofactor(int[,] intA, int[,] temp, int p, int q, int n)
        {
            try
            {

                int i = 0, j = 0;

                // Looping for each element of the matrix
                for (int row = 0; row < n; row++)
                {
                    for (int col = 0; col < n; col++)
                    {
                        //  Copying into temporary matrix only those element
                        //  which are not in given row and column
                        if (row != p && col != q)
                        {
                            temp[i, j++] = intA[row, col];

                            // Row is filled, so increase row index and
                            // reset col index
                            if (j == n - 1)
                            {
                                j = 0;
                                i++;
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }


        public MatrixManipulation()

        {
            try
            {
                string strMyChoice = "y";

                while (strMyChoice == "y" || strMyChoice == "Y" || strMyChoice == "yes" || strMyChoice == "YES" || strMyChoice == "Yes")
                {
                    Console.WriteLine("-------------");
                    Console.WriteLine(value: "1. Addition");
                    Console.WriteLine(value: "2. Subtraction");
                    Console.WriteLine(value: "3. Multiplication");
                    Console.WriteLine(value: "4. Inverse");
                    Console.WriteLine("----------------------");




                    Console.WriteLine("Enter your choice");
                    int intChoice = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("----------------------");

                    switch (intChoice)
                    {
                        case 1:
                            addition();
                            break;
                        case 2:
                            subtraction();
                            break;
                        case 3:
                            multiplication();
                            break;
                        case 4:
                            inverse();
                            break;

                        default:
                            Console.WriteLine("Invalid Choice!!! Enter correct choice");
                            break;

                    }
                    Console.WriteLine("Do you want to continue doing MAtrix Manipulation  (y/n)");
                    strMyChoice = Console.ReadLine();



                }


            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message + "");
            }
        }
    }
}


