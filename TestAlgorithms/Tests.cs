using AlgorithmsLibrary;
using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace TestAlgorithms
{
    public class Tests
    {
        private Algorithms algInstance = new Algorithms();

        [SetUp]
        public void Setup()
        {
            if (algInstance == null)
            {
                algInstance = new Algorithms();
            }

        }

        [Test]
        public void TestSortIntList()
        {
            bool errorOccured = false;

            try
            {
                List<int> listForTesting = new List<int> { 4, 1, 2, 3 };
                List<int> listForTesting1 = new List<int> { 0 };
                List<int> listForTesting2 = new List<int> { -5, 0, 4, 3 };
                List<int> listForTesting3 = new List<int> { -8, -11, -50, 99 };
                List<int> listForTesting4 = new List<int> { 100, -100, 99 };

                var result = algInstance.IsEqualList(new List<int> { 1, 2, 3, 4 }, algInstance.SortIntList(listForTesting, Enumaration.SortingType.ASC));
                var result1 = algInstance.IsEqualList(new List<int> { 0 }, algInstance.SortIntList(listForTesting1, Enumaration.SortingType.ASC));
                var result2 = algInstance.IsEqualList(new List<int> { -5, 0, 3, 4 }, algInstance.SortIntList(listForTesting2, Enumaration.SortingType.ASC));
                var result3 = algInstance.IsEqualList(new List<int> { -50, -11, -8, 99 }, algInstance.SortIntList(listForTesting3, Enumaration.SortingType.ASC));
                var result4 = algInstance.IsEqualList(new List<int> { -100, 99, 100 }, algInstance.SortIntList(listForTesting4, Enumaration.SortingType.ASC));

                if ((!result) || (!result1) || (!result2) || (!result3) || (!result4))
                {
                    errorOccured = true;
                }

            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
            finally
            {
                if (errorOccured)
                {
                    Assert.Fail();
                }
            }

        }

        [Test]
        public void TestBinarySearch()
        {
            bool errorOccured = false;
 
            try
            {
                int value = algInstance.BinarySearchFindIndex(new int[] { 7, -11, 99, 2, 0 }, 3);

                if (value != -1)
                {
                    errorOccured = true;
                }

                int value2 = algInstance.BinarySearchFindIndex(new int[] { 7, -11, 99, 2, 0 }, -11);

                if (value2 != -11)
                {
                    errorOccured = true;
                }

                int value3 = algInstance.BinarySearchFindIndex(new int[] { 3, -77, 2, 2, -1 }, 2);

                if (value3 != 2)
                {
                    errorOccured = true;
                }

            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
            finally
            {
                if (errorOccured)
                {
                    Assert.Fail();
                }
            }
         

           
        }

        [Test]
        public void TestStringAnagram()
        {
            bool result = true;
            bool errorOccured = false;
       
            try
            {
                result = algInstance.TestIsStringAnagram("Test12", "1Tset2");

                if (!result)
                {
                    errorOccured = true;
                }

                result = algInstance.TestIsStringAnagram(String.Empty, "1Tset2");


                if (result)
                {
                    errorOccured = true;
                }


                result = algInstance.TestIsStringAnagram(String.Empty, String.Empty);

                if (!result)
                {
                    errorOccured = true;
                }

                result = algInstance.TestIsStringAnagram("Testtt", String.Empty);

                if (result)
                {
                    errorOccured = true;
                }

                result = algInstance.TestIsStringAnagram("Testtt", "Test1234");

                if (result)
                {
                    errorOccured = true;
                }
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
            finally
            {
                if (errorOccured)
                {
                    Assert.Fail();
                }
            }

        }

        //[Test]
        //public void TestIntArrayEqual()
        //{



        //}
    }
}