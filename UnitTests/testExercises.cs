using EulerProject.Algorithms;
namespace UnitTests
{

    [TestClass]
    public class testExercises
    {
        [DataRow(0)]
        [DataRow(1)]
        [DataRow(2)]
        [DataRow(3)]
        [TestMethod]
        public void EulerProject_1_returnsInt(int test)
        {
            //Arrange
            IDictionary<int, int> cases = new Dictionary<int, int>() {
                { 49, 543 },
                { 1000, 233168 },
                { 8456, 16687353 },
                { 19564, 89301183 }
            };
            //Act
            int result = _1.multiplesOf3and5(cases.ElementAt(test).Key);
            //Assert
            Assert.AreEqual(cases.ElementAt(test).Value, result, $"The expected value is {cases.ElementAt(test).Value} but we got {result}");
        }
        [DataRow(0)]
        [DataRow(1)]
        [DataRow(2)]
        [DataRow(3)]
        [TestMethod]
        public void EulerProject_2_returnsInt(int test)
        {
            //Arrange
            IDictionary<int, int> cases = new Dictionary<int, int>() {
                { 8, 10 },
                { 10, 10 },
                { 34, 44 },
                { 60, 44 }
            };
            //Act
            int result = _2.fiboEvenSum(cases.ElementAt(test).Key);
            //Assert
            Assert.IsTrue(cases.ElementAt(test).Value == result, $"The expected value is {cases.ElementAt(test).Value} but we got {result}");
        }

        [DataRow(0)]
        [DataRow(1)]
        [DataRow(2)]
        [DataRow(3)]
        [DataRow(4)]
        [DataRow(5)]
        [DataRow(6)]
        [TestMethod]
        public void EulerProject_3_returnsLong(int test)
        {
            //Arrange
            IDictionary<long, long> cases = new Dictionary<long, long>() {
                { 2, 2 },
                { 3, 3 },
                { 5, 5 },
                { 7, 7 },
                { 8, 2 },
                { 13195, 29 },
                { 600851475143, 6857 }
            };
            //Act
            long res = _3.largestPrimeFactor(cases.ElementAt(test).Key);
            //Assert
            Assert.IsTrue(res == cases.ElementAt(test).Value, $"The expected value is {cases.ElementAt(test).Value} but we got {res}");
        }

        [DataRow(0)]
        [DataRow(1)]
        [TestMethod]
        public void EulerProject_4_returnsInt(int test)
        {
            //Arrange
            IDictionary<int, int> cases = new Dictionary<int, int>() {
                { 2, 9009 },
                { 3, 906609 }
            };
            //Act
            int res = _4.largestPalindromeProduct(cases.ElementAt(test).Key);
            //Assert
            Assert.IsTrue(res == cases.ElementAt(test).Value, $"The expected value is {cases.ElementAt(test).Value} but we got {res}");
        }

        [DataRow(0)]
        [DataRow(1)]
        [DataRow(2)]
        [DataRow(3)]
        [DataRow(4)]
        [TestMethod]
        public void EulerProject_5_returnsInt(int test)
        {
            //Arrange
            IDictionary<int, int> cases = new Dictionary<int, int>() {
                { 5, 60},
                { 7, 420},
                { 10, 2520},
                {13, 360360 },
                {20, 232792560 }
            };
            //Act
            int res = _5.smallestMult(cases.ElementAt(test).Key);
            //Assert
            Assert.IsTrue(res == cases.ElementAt(test).Value, $"The expected value is {cases.ElementAt(test).Value} but we got {res}");
        }

        [DataRow(0)]
        [DataRow(1)]
        [DataRow(2)]
        [TestMethod]
        public void EulerProject_6_returnsDouble(int test)
        {
            //Arrange
            IDictionary<int, double> cases = new Dictionary<int, double>() {
                { 10, 2640},
                { 20, 41230},
                { 100, 25164150}
            };
            //Act
            double res = _6.sumSquareDifference(cases.ElementAt(test).Key);
            //Assert
            Assert.IsTrue(res == cases.ElementAt(test).Value, $"The expected value is {cases.ElementAt(test).Value} but we got {res}");
        }

        [DataRow(0)]
        [DataRow(1)]
        [DataRow(2)]
        [DataRow(3)]
        [DataRow(4)]
        [TestMethod]
        public void EulerProject_7_returnsInt(int test)
        {
            //Arrange
            IDictionary<int, int> cases = new Dictionary<int, int>() {
                { 6, 13 },
                { 10, 29 },
                { 100, 541 },
                { 1000, 7919 },
                { 10001, 104743 }
            };
            //Act
            double res = _7.nthPrime(cases.ElementAt(test).Key);
            //Assert
            Assert.IsTrue(res == cases.ElementAt(test).Value, $"The expected value is {cases.ElementAt(test).Value} but we got {res}");
        }

    }
}