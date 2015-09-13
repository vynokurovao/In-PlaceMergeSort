using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MergeSort;

namespace MergeSortTest
{
    [TestClass]
    public class MergeSorterTest
    {
        private int[] bigActualSorted_NotDevidedEvenly = new int[1000];
        private int[] bigActualDescSorted_NotDevidedEvenly = new int[1000];
        private int[] bigActualEqualsNumbers_NotDevidedEvenly = new int[1000];
        private int[] bigExpected_NotDevidedEvenly = new int[1000];
        private int[] bigExpectedEqualsNumbers_NotDevidedEvenly = new int[1000];

        private int[] bigActualSorted_EvenlyDevided = new int[990];
        private int[] bigActualDescSorted_EvenlyDevided = new int[990];
        private int[] bigActualEqualsNumbers_EvenlyDevided = new int[990];
        private int[] bigExpected_EvenlyDevided = new int[990];
        private int[] bigExpectedEqualsNumbers_EvenlyDevided = new int[990];

        private void Initialize_NotDevivedEvenly()
        {
            for (int i = 0; i < 1000; ++i)
            {
                bigActualSorted_NotDevidedEvenly[i] = i;
                bigActualDescSorted_NotDevidedEvenly[i] = 999 - i;
                bigExpected_NotDevidedEvenly[i] = i;
                bigActualEqualsNumbers_NotDevidedEvenly[i] = 8;
                bigExpectedEqualsNumbers_NotDevidedEvenly[i] = 8;
            }
        }

        private void Initialize_EvenlyDevided()
        {
            for (int i = 0; i < 990; ++i)
            {
                bigActualSorted_EvenlyDevided[i] = i;
                bigActualDescSorted_EvenlyDevided[i] = 989 - i;
                bigExpected_EvenlyDevided[i] = i;
                bigActualEqualsNumbers_EvenlyDevided[i] = 8;
                bigExpectedEqualsNumbers_EvenlyDevided[i] = 8;
            }
        }

        [TestMethod]
        public void MergeSorter_WithEmptyArray()
        {
            int[] actual = new int[0] { };
            MergeSorter.MergeSort(ref actual);
            int[] expected = new int[0] { };

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void MergeSorter_WithOneElementArray()
        {
            int[] actual = new int[1] { 7 };
            MergeSorter.MergeSort(ref actual);
            int[] expected = new int[1] { 7 };

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void MergeSorter_WithEvenQuantity_SortedArray()
        {
            int[] actual = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            MergeSorter.MergeSort(ref actual);
            int[] expected = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void MergeSorter_WithEvenQuantity_DescSortedArray()
        {
            int[] actual = new int[10] { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };
            MergeSorter.MergeSort(ref actual);
            int[] expected = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void MergeSorter_WithEvenQuantity_ArrayOfEqualNumbers()
        {
            int[] actual = new int[10] { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 };
            MergeSorter.MergeSort(ref actual);
            int[] expected = new int[10] { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 };

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void MergeSorter_WithOddQuantity_SortedArray()
        {
            int[] actual = new int[11] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };
            MergeSorter.MergeSort(ref actual);
            int[] expected = new int[11] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void MergeSorter_WithOddQuantity_DescSortedArray()
        {
            int[] actual = new int[11] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };
            MergeSorter.MergeSort(ref actual);
            int[] expected = new int[11] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void MergeSorter_WithOddQuantity_ArrayOfEqualNumbers()
        {
            int[] actual = new int[11] { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 };
            MergeSorter.MergeSort(ref actual);
            int[] expected = new int[11] { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 };

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void MergeSorter_With_NotDevidedEvenlyQuantity_BigSortedArray()
        {
            MergeSorter.MergeSort(ref bigActualSorted_NotDevidedEvenly);

            CollectionAssert.AreEqual(bigExpected_NotDevidedEvenly, bigActualSorted_NotDevidedEvenly);
        }

        [TestMethod]
        public void MergeSorter_With_NotDevidedEvenlyQuantity_BigDescSortedArray()
        {
            MergeSorter.MergeSort(ref bigActualDescSorted_NotDevidedEvenly);

            CollectionAssert.AreEqual(bigExpected_NotDevidedEvenly, bigActualDescSorted_NotDevidedEvenly);
        }

        [TestMethod]
        public void MergeSorter_With_NotDevidedEvenlyQuantity_BigArrayOfEqualNumbers()
        {
            MergeSorter.MergeSort(ref bigActualEqualsNumbers_NotDevidedEvenly);

            CollectionAssert.AreEqual(bigExpectedEqualsNumbers_NotDevidedEvenly, bigActualEqualsNumbers_NotDevidedEvenly);
        }

        [TestMethod]
        public void MergeSorter_With_EvenlyDevidedQuantity_BigSortedArray()
        {
            MergeSorter.MergeSort(ref bigActualSorted_EvenlyDevided);

            CollectionAssert.AreEqual(bigExpected_EvenlyDevided, bigActualSorted_EvenlyDevided);
        }

        [TestMethod]
        public void MergeSorter_With_EvenlyDevidedQuantity_BigDescSortedArray()
        {
            MergeSorter.MergeSort(ref bigActualDescSorted_EvenlyDevided);

            CollectionAssert.AreEqual(bigExpected_EvenlyDevided, bigActualDescSorted_EvenlyDevided);
        }

        [TestMethod]
        public void MergeSorter_With_EvenlyDevidedQuantity_BigArrayOfEqualNumbers()
        {
            MergeSorter.MergeSort(ref bigActualEqualsNumbers_EvenlyDevided);

            CollectionAssert.AreEqual(bigExpectedEqualsNumbers_EvenlyDevided, bigActualEqualsNumbers_EvenlyDevided);
        }
    }
}