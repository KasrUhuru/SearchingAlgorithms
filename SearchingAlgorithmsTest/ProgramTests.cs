using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void LinearSearch_TargetIsInArray_ShouldReturnValidIndex()
        {
            // Consider the Triple A's of testing: Arrange, Act, Assert
            // Arrange: Setting up the mock-ups
            int[] arr1 = { 1, 1, 2, 2, 2, 2, 2, 3, 4, 4, 4, 4, 4, 4, 5, 6, 7, 8, 9, 10 };
            // Act: Call the code you want to test
            int arr1Result = SearchingAlgorithms.LinearSearch(arr1, 16);
            // Assert: This is the outcome that you expect. The hypothesis to be tested
            Assert.AreEqual(arr1Result, -1);
        }

        [TestMethod()]
        public void LinearSearch_TargetIsNotInArray_ShouldReturnNegativeOne()
        {
            // Consider the Triple A's of testing: Arrange, Act, Assert
            // Arrange: Setting up the mock-ups
            int[] arr1 = { 1, 1, 2, 2, 2, 2, 2, 3, 4, 4, 4, 4, 4, 4, 5, 6, 7, 8, 9, 10 };
            // Act: Call the code you want to test
            int arr1Result = SearchingAlgorithms.LinearSearch(arr1, 3);
            // Assert: This is the outcome that you expect. The hypothesis to be tested
            Assert.AreEqual(arr1Result, 7);
        }

        [TestMethod()] 
        public void BinarySearch_TargetIsInArray_TargetIsHigherInArray_ShouldReturnValidIndex()
        {
            // AAA
            // Arrange the mockup
            int[] arr2 = { 0, 1, 2, 3, 4,5, 6, 7, 8, 9, 10 };
            // Act
            int arrResult = SearchingAlgorithms.BinarySearch(arr2, 9);
            // Assert
            Assert.AreEqual(arrResult, 9);
        }
    }
}