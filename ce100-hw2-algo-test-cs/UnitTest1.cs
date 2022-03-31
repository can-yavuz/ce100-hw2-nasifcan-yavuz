using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ce100_hw2_algo_lib_cs;

namespace ce100_hw2_algo_test_cs
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void HeapSortTestMethod1()
        {
            int[] array = new int[] { 15, 25, 45, 35, 55 };
            int n = array.Length;
            int[] expected = new int[] { 15, 25, 35, 45, 55 };

            Class1.heapSort(array, n);
            CollectionAssert.AreEqual(expected, array);
        }

        [TestMethod]
        public void HeapSortTestMethod2()
        {
            int[] array = new int[] { 0, 9, 5, 3, 2, 7, 6 };
            int n = array.Length;
            int[] expected = new int[] { 0, 2, 3, 5, 6, 7, 9 };

            Class1.heapSort(array, n);
            CollectionAssert.AreEqual(expected, array);
        }
        [TestMethod]
        public void HeapSortTestMethod3()
        {
            int[] array = new int[] { 35, -25, 15, 0, -15, 25, -35 };
            int n = array.Length;
            int[] expected = new int[] { -35, -25, -15, 0, 15, 25, 35 };

            Class1.heapSort(array, n);
            CollectionAssert.AreEqual(expected, array);
        }

        [TestMethod]
        public void RadixSortTestMethod1()
        {
            int[] array = new int[] { 40, 80, 10, 30, 70, 60, 20, 90, 50, 0 };
            int n = array.Length;
            int[] expected = new int[] { 0, 10, 20, 30, 40, 50, 60, 70, 80, 90 };

            Class1.radixsort(array, n);
            CollectionAssert.AreEqual(expected, array);
        }

        [TestMethod]
        public void RadixSortTestMethod2()
        {
            int[] array = new int[] { 1570, 455, 755, 950, 8502, 254, 25, 656 };
            int n = array.Length;
            int[] expected = new int[] { 25, 254, 455, 656, 755, 950, 1570, 8502 };

            Class1.radixsort(array, n);
            CollectionAssert.AreEqual(expected, array);
        }

        [TestMethod]
        public void RadixSortTestMethod3()
        {
            int[] array = new int[] { 450, 12, 86, 42, 153, 90, 4, 5 };
            int n = array.Length;
            int[] expected = new int[] { 4, 5, 12, 42, 86, 90, 153, 450 };

            Class1.radixsort(array, n);
            CollectionAssert.AreEqual(expected, array);
        }

        [TestMethod]
        public void CountingSortTestMethod1()
        {
            int[] array = new int[] { 450, 12, 86, 42, 153, 90, 4, 5 };
            int[] expected = new int[] { 4, 5, 12, 42, 86, 90, 153, 450 };

            Class1.countingsort(array);
            CollectionAssert.AreEqual(expected, array);
        }

        [TestMethod]
        public void CountingSortTestMethod2()
        {
            int[] array = new int[] { 15, 25, 35, 55, 45, 65, 50 };
            int[] expected = new int[] { 15, 25, 35, 45, 50, 55, 65, };

            Class1.countingsort(array);
            CollectionAssert.AreEqual(expected, array);
        }

        [TestMethod]
        public void CountingSortTestMethod3()
        {
            int[] array = new int[] { 33, 77, 99, 111, 55 };
            int[] expected = new int[] { 33, 55, 77, 99, 111 };

            Class1.countingsort(array);
            CollectionAssert.AreEqual(expected, array);
        }



        [TestMethod]
        public void QuickSortLomutoTestMethod1()
        {
            int[] array = new int[] { 105, 75, 85, 95, 15, 55 };
            int[] expected = new int[] { 15, 55, 75, 85, 95, 105 };
            int n = array.Length;
            Class1.quickSortLomuto(array, 0, n - 1);
            CollectionAssert.AreEqual(expected, array);
        }

        [TestMethod]
        public void QuickSortLomutoTestMethod2()
        {
            int[] array = new int[] { 482, 185, 783, 288, 985, 389, 18, 681 };
            int[] expected = new int[] { 18, 185, 288, 389, 482, 681, 783, 985 };
            int n = array.Length;
            Class1.quickSortLomuto(array, 0, n - 1);
            CollectionAssert.AreEqual(expected, array);
        }

        [TestMethod]
        public void QuickSortLomutoTestMethod3()
        {
            int[] array = new int[] { 1970, 495, 795, 990, 8902, 294, 29, 696 };
            int[] expected = new int[] { 29, 294, 495, 696, 795, 990, 1970, 8902 };
            int n = array.Length;
            Class1.quickSortLomuto(array, 0, n - 1);
            CollectionAssert.AreEqual(expected, array);
        }



        [TestMethod]
        public void QuickSortHoaresTestMethod1()
        {
            int[] array = new int[] { 110, 71, 81, 91, 11, 51 };
            int[] expected = new int[] { 11, 51, 71, 81, 91, 110 };
            int n = array.Length;
            Class1.quickSortHoares(array, 0, n - 1);
            CollectionAssert.AreEqual(expected, array);
        }


        [TestMethod]
        public void QuickSortHoaresTestMethod2()
        {
            int[] array = new int[] { 42, 15, 73, 28, 95, 39, 1, 61 };
            int[] expected = new int[] { 1, 15, 28, 39, 42, 61, 73, 95 };
            int n = array.Length;
            Class1.quickSortHoares(array, 0, n - 1);
            CollectionAssert.AreEqual(expected, array);
        }


        [TestMethod]
        public void QuickSortHoaresTestMethod3()
        {
            int[] array = new int[] { 1070, 405, 705, 900, 8002, 204, 20, 606 };
            int[] expected = new int[] { 20, 204, 405, 606, 705, 900, 1070, 8002 };
            int n = array.Length;
            Class1.quickSortHoares(array, 0, n - 1);
            CollectionAssert.AreEqual(expected, array);
        }


        [TestMethod]
        public void multiplyMatrixRecTestMethod1()
        {
            int row1 = 3, col1 = 3,
            row2 = 3, col2 = 3;
            int[,] A = {{54, 32, 15},
                    {87, 98, 12},
                    {54, 61, 76}};

            int[,] B = {{15, 49, 87},
                    {35, 48, 21},
                    {65, 48, 20}};

            int[,] C = new int[row1, col2];

            int[,] expected = { { 2905, 4902, 5670 }, { 5515, 9543, 9867 }, { 7885, 9222, 7499 } };
            Class1.multiplyMatrixRec(row1, col1, A, row2, col2, B, C);
            CollectionAssert.AreEqual(expected, C);
        }



        [TestMethod]
        public void multiplyMatrixRecTestMethod2()
        {
            int row1 = 3, col1 = 3,
            row2 = 3, col2 = 3;
            int[,] A = {{5, 8, 10},
                       {3, 2, 4},
                       {6, 7, 9}};
            Class1.i = 0; Class1.j = 0; Class1.k = 0;
            int[,] B = {{1, 4, 7},
                       {9, 10, 12},
                       {5, 8, 6}};

            int[,] C = new int[row1, col2];

            int[,] expected = { { 127, 180, 191 }, { 41, 64, 69 }, { 114, 166, 180 } };
            Class1.multiplyMatrixRec(row1, col1, A, row2, col2, B, C);
            CollectionAssert.AreEqual(expected, C);
        }


        [TestMethod]
        public void multiplyMatrixRecTestMethod3()
        {
            int row1 = 2, col1 = 2,
            row2 = 2, col2 = 2;
            int[,] A = {{4,5},
                    {6, 7}};
            Class1.i = 0; Class1.j = 0; Class1.k = 0;

            int[,] B = {{8,9},
                    {10,11}};

            int[,] C = new int[row1, col2];

            int[,] expected = { { 82, 91 }, { 118, 131 } };
            Class1.multiplyMatrixRec(row1, col1, A, row2, col2, B, C);
            CollectionAssert.AreEqual(expected, C);
        }





        [TestMethod]
        public void multiplyMatrixIterativeTestMethod1()
        {

            int[,] A = {{ 0 ,0 ,0 ,0 },
                         { 5 ,5 ,5 ,5 },
                         { 4 ,4 ,4, 4 },
                         { 3, 3, 3, 3 }};
            Class1.i = 0; Class1.j = 0; Class1.k = 0;
            int N = 4;
            int[,] B = { {8, 8, 8, 8 },
                         { 0, 0, 0, 0 },
                         { 9, 9, 9, 9 },
                         { 4, 4, 4, 4 }};

            int[,] C = new int[N, N];

            int[,] expected = { { 0,0,0,0 },
                                { 105,105,105,105},
                                { 84,84,84,84},
                                { 63,63,63,63} };
            Class1.multiply(A, B, C);
            CollectionAssert.AreEqual(expected, C);
        }



        [TestMethod]
        public void multiplyMatrixIterativeTestMethod2()
        {

            int[,] A = {{ 1, 2, 3, 4 },
                         { 5, 6, 7, 8 },
                         { 1, 2, 3, 4 },
                         { 5, 6, 7, 8 }};
            Class1.i = 0; Class1.j = 0; Class1.k = 0;
            int N = 4;
            int[,] B = { { 1, 2, 3, 4 },
                         { 5, 6, 7, 8 },
                         { 1, 2, 3, 4 },
                         { 5, 6, 7, 8 }};

            int[,] C = new int[N, N];

            int[,] expected = { { 34,44,54,64 },
                                { 82,108,134,160},
                                { 34,44,54,64 },
                                { 82,108,134,160} };
            Class1.multiply(A, B, C);
            CollectionAssert.AreEqual(expected, C);
        }



        [TestMethod]
        public void multiplyMatrixIterativeTestMethod3()
        {

            int[,] A = {{ 3,5,7,9},
                         { 2,4,6,8},
                         { 1,3,2,7},
                         { 1,0,5,7} };
            Class1.i = 0; Class1.j = 0; Class1.k = 0;
            int N = 4;
            int[,] B = { { 8,7,6,5},
                         { 4,8,12,16},
                         { 0,2,3,4},
                         { 0,0,0,0 } };

            int[,] C = new int[N, N];

            int[,] expected = { { 44,75,99,123 },
                                { 32,58,78,98},
                                { 20,35,48,61 },
                                { 8,17,21,25} };
            Class1.multiply(A, B, C);
            CollectionAssert.AreEqual(expected, C);
        }




        [TestMethod]
        public void MatrixMulStrTest1()
        {
            float[,] array = { { 3,5 },
                           { 5,3 } };


            float[,] array2 = { { 5,9 },
                            { 3,8 } };

            float[,] result = { { 30,67 },
                            { 34,69 } };

            float[,] exp = Class1.strassen(array, array2, 2);
            CollectionAssert.AreEqual(exp, result);
        }



        [TestMethod]
        public void MatrixMulStrTest2()
        {
            float[,] array = { { 4, 8 },
                           { 7, 5 } };


            float[,] array2 = { { 8, 2 },
                            { 7, 9 } };

            float[,] result = { { 88, 80 },
                            { 91, 59 } };

            float[,] exp = Class1.strassen(array, array2, 2);
            CollectionAssert.AreEqual(exp, result);
        }

        [TestMethod]
        public void MatrixMulStrTest3()
        {
            float[,] array = { { 8, 3 },
                           { 9, 10 } };


            float[,] array2 = { { 4, 7 },
                            { 9, 7 } };

            float[,] result = { { 59,77 },
                            { 126, 133 } };

            float[,] exp = Class1.strassen(array, array2, 2);
            CollectionAssert.AreEqual(exp, result);
        }


        [TestMethod]
        public void RandomizedQuickSortLomutoTestMethod1()
        {
            int[] array = new int[] { 1870, 485, 785, 980, 8802, 284, 28, 686 };
            int[] expected = new int[] { 28, 284, 485, 686, 785, 980, 1870, 8802 };
            int n = array.Length;
            Class1.randomQuickSortLomuto(array, 0, n - 1);
            CollectionAssert.AreEqual(expected, array);
        }

        [TestMethod]
        public void RandomizedQuickSortLomutoTestMethod2()
        {
            int[] array = new int[] { 142, 115, 173, 128, 195, 139, 11, 161 };
            int[] expected = new int[] { 11, 115, 128, 139, 142, 161, 173, 195 };
            int n = array.Length;
            Class1.randomQuickSortLomuto(array, 0, n - 1);
            CollectionAssert.AreEqual(expected, array);
        }


        [TestMethod]
        public void RandomizedQuickSortLomutoTestMethod3()
        {
            int[] array = new int[] { 4, 5, 7, 9, 1, 3 };
            int[] expected = new int[] { 1, 3, 4, 5, 7, 9 };
            int n = array.Length;
            Class1.randomQuickSortLomuto(array, 0, n - 1);
            CollectionAssert.AreEqual(expected, array);
        }


        [TestMethod]
        public void RandomizedQuickSortHoaresTestMethod1()
        {
            int[] array = new int[] { 140, 74, 84, 94, 14, 54 };
            int[] expected = new int[] { 14, 54, 74, 84, 94, 140 };
            int n = array.Length;
            Class1.randomQuicksortHoare(array, 0, n - 1);
            CollectionAssert.AreEqual(array, expected);
        }


        [TestMethod]
        public void RandomizedQuickSortHoaresTestMethod2()
        {
            int[] array = new int[] { 942, 915, 973, 928, 995, 939, 91, 961 };
            int[] expected = new int[] { 91, 915, 928, 939, 942, 961, 973, 995 };
            int n = array.Length;
            Class1.randomQuicksortHoare(array, 0, n - 1);
            CollectionAssert.AreEqual(array, expected);
        }


        [TestMethod]
        public void RandomizedQuickSortHoaresTestMethod3()
        {
            int[] array = new int[] { 486, 123, 458, 2, 145, 44, 33, 852, 612, 952 };
            int[] expected = new int[] { 2, 33, 44, 123, 145, 458, 486, 612, 852, 952 };
            int n = array.Length;
            Class1.randomQuicksortHoare(array, 0, n - 1);
            CollectionAssert.AreEqual(array, expected);
        }


        [TestMethod]
        public void PrioritryHeapSortTestMethod1()
        {

            int[] arr = new int[] { 405, 102, 708, 207, 603 };
            Class1.insert(708);
            Class1.insert(603);
            Class1.insert(405);
            Class1.insert(207);
            Class1.insert(102);
            int expected = Class1.extractMax();
            Assert.AreEqual(708, expected);
        }


        [TestMethod]
        public void PrioritryHeapSortTestMethod2()
        {

            int[] arr = new int[] { 795, 194, 591, 99, 896, 697, 494, 392, 293, 999 };
            Class1.insert(999);
            Class1.insert(896);
            Class1.insert(795);
            Class1.insert(697);
            Class1.insert(591);
            Class1.insert(494);
            Class1.insert(392);
            Class1.insert(293);
            Class1.insert(194);
            Class1.insert(99);
            int expected = Class1.extractMax();
            Assert.AreEqual(999, expected);
        }

        [TestMethod]
        public void PrioritryHeapSortTestMethod3()
        {

            int[] arr = new int[] { 3451, 1781, 5461, 831, 1861, 9431, 7821, 6231 };
            Class1.insert(9431);
            Class1.insert(7821);
            Class1.insert(6231);
            Class1.insert(5461);
            Class1.insert(3451);
            Class1.insert(1861);
            Class1.insert(1781);
            Class1.insert(831);
            int expected = Class1.extractMax();
            Assert.AreEqual(9431, expected);
        }


        [TestMethod]
        public void SelectionProblemTest()
        {
            int[] arr = { 172, 37, 57, 77, 47, 179, 276 };
            int n = arr.Length, k = 3;
            int result = Class1.SelectionProblem(arr, 0, n - 1, k);
            Assert.AreEqual(57, result);
        }



    }
}
