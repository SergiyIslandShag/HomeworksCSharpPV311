namespace Array._Enum
{
	internal class Program
	{
		static void Main(string[] args)
		{
			#region One dimention arr

			//int[] arr = new int[5];

			//arr[0] = 10;

			//arr[1] = 20;

			//arr[2] = 30;

			//arr[3] = 40;

			//arr[4] = 50;

			//Console.WriteLine(arr[0]);

			//Console.WriteLine(arr[1]);

			//Console.WriteLine(arr[2]);

			//Console.WriteLine(arr[3]);

			//Console.WriteLine(arr[4]);


			//int[] arr2 = new int[5];

			//for (int i = 0; i < arr2.Length; i++)

			//{

			//    arr2[i] = i * 2;

			//}

			//for (int i = 0; i < arr2.Length; i++)

			//{

			//    Console.Write(arr2[i] + " ");

			//}

			//Console.WriteLine();


			//int[] arr3 = new int[5] { 1, 2, 3, 4, 5 };

			//for (int i = 0; i < arr3.Length; i++)

			//{

			//    Console.Write(arr3[i] + " ");

			//}

			//Console.WriteLine();

			//int[] arr4 = new int[] { 1, 2, 3, 4, 5, 32, 43, 53, 54, };

			//for (int i = 0; i < arr4.Length; i++)

			//{

			//    Console.Write(arr4[i] + " ");

			//}

			//Console.WriteLine();

			//int[] arr5 = new int[10];

			//for (int i = 0; i < arr5.Length; i++)

			//{

			//    Console.Write(arr5[i] + " ");

			//}

			//Console.WriteLine();

			//arr5.SetValue(77, 2);

			//arr5.SetValue(22, 3);

			//foreach (var item in arr4)

			//{

			//    Console.WriteLine(item);

			//}

			#endregion

			#region Two dimention arr

			//int[,] arr = new int[3, 3];

			//arr[0, 0] = 1;

			//arr[0, 1] = 2;

			//arr[0, 2] = 3;

			//arr[1, 0] = 4;

			//arr[1, 1] = 5;

			//arr[1, 2] = 6;

			//arr[2, 0] = 7;

			//arr[2, 1] = 8;

			//arr[2, 2] = 9;

			//Console.Write(arr[0, 0] + " ");

			//Console.Write(arr[0, 1] + " ");

			//Console.Write(arr[0, 2] + " ");

			//Console.WriteLine();

			//Console.Write(arr[1, 0] + " ");

			//Console.Write(arr[1, 1] + " ");

			//Console.Write(arr[1, 2] + " ");

			//Console.WriteLine();

			//Console.Write(arr[2, 0] + " ");

			//Console.Write(arr[2, 1] + " ");

			//Console.Write(arr[2, 2] + " ");

			//Console.WriteLine();

			////2

			//int[,] arr2 = new int[3, 5];

			//Console.WriteLine(arr2.Length);

			//for (int i = 0; i < arr2.GetLength(0); i++)

			//{

			//    for (int j = 0; j < arr2.GetLength(1); j++)

			//    {

			//        arr2[i, j] = i * j + 1;

			//    }

			//}

			//for (int i = 0; i <= arr2.GetUpperBound(0); i++)

			//{

			//    for (int j = 0; j <= arr2.GetUpperBound(1); j++)

			//    {

			//        Console.Write(arr2[i, j] + " ");

			//    }

			//    Console.WriteLine();

			//}

			/////4

			//int[,] arr4 =

			//{

			//      { 1,2,3},

			//      {4,5,6 },

			//      {7,8,9 }

			//  };

			//Console.WriteLine(arr4.Length);

			//Console.WriteLine(arr4);

			//for (int i = 0; i < 3; i++)

			//{

			//    for (int j = 0; j < 3; j++)

			//    {

			//        Console.Write($"{arr4[i, j]} ");

			//    }

			//    Console.WriteLine();

			//}

			#endregion

			#region DZ
			Console.WriteLine("#1");
			int[] numbers = { 14, 2, 3, 22, 5, 8, 3, 9, 11, 32, 22 };
			int evenCount = 0;
			int oddCount = 0;
			int uniqueCount = 0;
			for (int i = 0; i < numbers.Length; i++)
			{
				int number = numbers[i];
				if (number % 2 == 0)
				{
					evenCount++;
				}
				else
				{
					oddCount++;
				}
				//if (uniqueCount(number))

				//{

				//    uniqueCount++;

				//}
			}
			Console.WriteLine("Even count: " + evenCount);
			Console.WriteLine("Odd count: " + oddCount);
			Console.WriteLine("Unique count: " + uniqueCount);

			Console.WriteLine("#2");
			int[] numbers1 = { 1, 5, 2, 6, 3, 4 };
			int targetValue;
			Console.WriteLine("Enter a value: ");
			targetValue = int.Parse(Console.ReadLine());
			int count = 0;
			foreach (int number in numbers1)
			{
				if (number < targetValue)
				{
					count++;
				}
			}
			Console.WriteLine("Number of elements less than: " + targetValue + ": " + count);

			Console.WriteLine("#3");
			int[] A = new int[5];
			Console.WriteLine("Enter 5 numbers for array A:");
			for (int i = 0; i < A.Length; i++)
			{
				Console.Write($"A[{i}] = ");
				A[i] = int.Parse(Console.ReadLine());
			}

			double[,] B = new double[3, 4];
			Random rand = new Random();
			for (int i = 0; i < B.GetLength(0); i++)
			{
				for (int j = 0; j < B.GetLength(1); j++)
				{
					B[i, j] = rand.NextDouble() * 100;
				}
			}

			Console.WriteLine("Array A:");
			foreach (var item in A)
			{
				Console.Write(item + " ");
			}
			Console.WriteLine();

			Console.WriteLine("Array B:");
			for (int i = 0; i < B.GetLength(0); i++)
			{
				for (int j = 0; j < B.GetLength(1); j++)
				{
					Console.Write($"{B[i, j]:F2}\t");
				}
				Console.WriteLine();
			}

			int maxA = A[0];
			int minA = A[0];
			double sumA = 0;
			double productA = 1;

			foreach (var item in A)
			{
				if (item > maxA) maxA = item;
				if (item < minA) minA = item;
				sumA += item;
				productA *= item;
			}

			double maxB = B[0, 0];
			double minB = B[0, 0];
			double sumB = 0;
			double productB = 1;

			for (int i = 0; i < B.GetLength(0); i++)
			{
				for (int j = 0; j < B.GetLength(1); j++)
				{
					if (B[i, j] > maxB) maxB = B[i, j];
					if (B[i, j] < minB) minB = B[i, j];
					sumB += B[i, j];
					productB *= B[i, j];
				}
			}

			double totalMax = Math.Max(maxA, maxB);
			double totalMin = Math.Min(minA, minB);
			double totalSum = sumA + sumB;
			double totalProduct = productA * productB;

			Console.WriteLine("Overall Max Element: " + totalMax);
			Console.WriteLine("Overall Min Element: " + totalMin);
			Console.WriteLine("Total Sum of All Elements: " + totalSum);
			Console.WriteLine("Total Product of All Elements: " + totalProduct);

			Console.WriteLine("#4");
			int[,] B1 = new int[5, 5];
			for (int i = 0; i < B1.GetLength(0); i++)
			{
				for (int j = 0; j < B1.GetLength(1); j++)
				{
					B1[i, j] = rand.Next(-100, 101);
				}
			}
			Console.WriteLine("Array B1:");
			for (int i = 0; i < B1.GetLength(0); i++)
			{
				for (int j = 0; j < B1.GetLength(1); j++)
				{
					Console.Write($"{B1[i, j],4} ");
				}
				Console.WriteLine();
			}

			int min = B1[0, 0];
			int max = B1[0, 0];
			int minIndex = 0;
			int maxIndex = 0;

			for (int i = 0; i < B1.GetLength(0); i++)
			{
				for (int j = 0; j < B1.GetLength(1); j++)
				{
					if (B1[i, j] < min)
					{
						min = B1[i, j];
						minIndex = i * B1.GetLength(1) + j;
					}
					if (B1[i, j] > max)
					{
						max = B1[i, j];
						maxIndex = i * B1.GetLength(1) + j;
					}
				}
			}

			Console.WriteLine("Minimum Element: " + min);
			Console.WriteLine("Maximum Element: " + max);

			int startIndex = Math.Min(minIndex, maxIndex);
			int endIndex = Math.Max(minIndex, maxIndex);
			int sumBetween = 0;

			for (int index = startIndex + 1; index < endIndex; index++)
			{
				int row = index / B1.GetLength(1);
				int col = index % B1.GetLength(1);
				sumBetween += B1[row, col];
			}

			Console.WriteLine("Sum of Elements Between Min and Max: " + sumBetween);

			Console.WriteLine("#5");
			int[] A1 = new int[10];

			Console.WriteLine("Array A:");
			for (int i = 0; i < A1.Length; i++)
			{
				A1[i] = rand.Next(-100, 101);
				Console.Write(A1[i] + " ");
			}
			Console.WriteLine();

			int min1 = A1[0];
			for (int i = 1; i < A1.Length; i++)
			{
				if (A1[i] < min1)
				{
					min1 = A1[i];
				}
			}

			int count1 = 0;
			for (int i = 0; i < A1.Length; i++)
			{
				if (A1[i] == min1 + 5 || A1[i] == min1 - 5)
				{
					count1++;
				}
			}

			Console.WriteLine("Minimum element: " + min1);
			Console.WriteLine("Number of elements differing from the minimum by 5: " + count1);
			#endregion
		}
	}
}
