using NUnit.Framework;
using Matrix.Application;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Matrix.Tests
{
    public class MatrixTests
    {
        private IMatrix _matrixTest;
        private ServiceProvider _serviceProvider;

        [SetUp]
        public void Setup()
        {
            _serviceProvider = new ServiceCollection()
                .AddSingleton<IMatrix, MatrixApplication>()
                .BuildServiceProvider();

            _matrixTest = _serviceProvider.GetService<IMatrix>();
        }

        [Test]
        public void TestSum()
        {
            int[,] matrixTest1 = new int[,] { { 4, 5, 6 }, { 4, 7, 9 }, { 10, 15, 13 } };
            int[,] matrixTest2 = new int[,] { { 10, 15, 26 }, { 44, 75, 19 }, { 10, 14, 73 }, { 52, 15, 36 } };

            Assert.AreEqual(24, _matrixTest.MatrixSum(matrixTest1));
            Assert.AreEqual(158, _matrixTest.MatrixSum(matrixTest2));
        }
                
        [Test]
        public void TestInvalidData()
        {
            int a = -1;
            int b = 10;
                        
            bool callFailed = false;

            try
            {
                var actualResult = _matrixTest.MatrixCreation(a, b);
            }
            catch (OverflowException)
            {
                callFailed = true;
            }

            Assert.IsTrue(callFailed, "Excpected call to MatrixCreation method failed with OverflowException");
        }

        [Test]
        public void TestNull()
        {
            int[,] matrix = null;

            bool callFailed = false;

            try
            {
                var actualResult = _matrixTest.MatrixSum(matrix);
            }
            catch (NullReferenceException)
            {
                callFailed = true;
            }

            Assert.IsTrue(callFailed, "Excpected call of MatrixSum method failed with NullReferenceException");
        }
    }
}