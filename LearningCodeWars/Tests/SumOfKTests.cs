using NUnit.Framework;
using System;
using System.Collections.Generic;
using LearningCodeWars.Solutions;

namespace LearningCodeWars.Tests
{
    [TestFixture]
    public class SumOfKTests
    {

        [Test]
        public void Test1()
        {
            Console.WriteLine("****** Basic Tests");
            var listOfDistances = new List<int> { 50, 55, 56, 57, 58 };
            var n = SumOfK.ChooseBestSum(115, 2, listOfDistances);
            Assert.AreEqual(115, n);


            listOfDistances = new List<int> { 50, 55, 56, 57, 58 };
            n = SumOfK.ChooseBestSum(163, 3, listOfDistances);
            Assert.AreEqual(163, n);

            //Check for Nulls

            //when list and maxSum of distances and towns are 0
            listOfDistances = new List<int>();
            n = SumOfK.ChooseBestSum(0, 0, listOfDistances);
            Assert.AreEqual(null, n);


            listOfDistances = new List<int>();
            n = SumOfK.ChooseBestSum(163, 0, listOfDistances);
            Assert.AreEqual(null, n);

            listOfDistances = new List<int>();
            n = SumOfK.ChooseBestSum(0, 4, listOfDistances);
            Assert.AreEqual(null, n);

            listOfDistances = new List<int>();
            n = SumOfK.ChooseBestSum(163, 1, listOfDistances);
            Assert.AreEqual(null, n);

            
            //return null if k is higher than the elements of ls
            listOfDistances = new List<int> { 50 };
            n = SumOfK.ChooseBestSum(163, 3, listOfDistances);
            Assert.AreEqual(null, n);

            //return null if nr of cities = 0 
            listOfDistances = new List<int> { 50 };
            n = SumOfK.ChooseBestSum(163, 0, listOfDistances);
            Assert.AreEqual(null, n);

            //return null if cities and max distance is empty
            listOfDistances = new List<int> { 50, 55, 56, 57, 58 };
            n = SumOfK.ChooseBestSum(0, 0, listOfDistances);
            Assert.AreEqual(null, n);


            //return null if cities and max distance is empty
            listOfDistances = new List<int> { 50, 55, 56, 57, 58 };
            n = SumOfK.ChooseBestSum(0, 1, listOfDistances);
            Assert.AreEqual(null, n);


            //return null if cities and max distance is empty
            listOfDistances = new List<int> { 5089, 34555, 34556, 555557, 693958 };
            n = SumOfK.ChooseBestSum(10, 2, listOfDistances);
            Assert.AreEqual(null, n);

            //return null if cities and max distance is empty
            listOfDistances = new List<int> { 5089, 34555, 34556, 555557, 693958 };
            n = SumOfK.ChooseBestSum(10, 7, listOfDistances);
            Assert.AreEqual(null, n);

            listOfDistances = new List<int> { 91, 74, 73, 85, 73, 81, 87 };
            n = SumOfK.ChooseBestSum(230, 3, listOfDistances);
            Assert.AreEqual(228, n);


            listOfDistances = new List<int> { 191, 274, 173, 385, 273, 481, 187 };
            n = SumOfK.ChooseBestSum(190, 1, listOfDistances);
            Assert.AreEqual(187, n);

            listOfDistances = new List<int> { 1, 0, 173, 385, 3, 481, 187 };
            n = SumOfK.ChooseBestSum(10, 2, listOfDistances);
            Assert.AreEqual(4, n);

            listOfDistances = new List<int> { 111, 100, 173, 385, 3, 481, 187, 234, 45 };
            n = SumOfK.ChooseBestSum(1000, 4, listOfDistances);
            Assert.AreEqual(999, n);


        }
    }
}