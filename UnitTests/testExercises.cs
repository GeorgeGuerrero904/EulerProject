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
        public void testExercise1(int test)
        {
            IDictionary<int, int> cases = new Dictionary<int, int>() {
                { 49, 543 },
                { 1000, 233168 },
                { 8456, 16687353 },
                { 19564, 89301183 }
            };
            long result = _1.multiplesOf3and5(cases.ElementAt(test).Key);
            Assert.AreEqual(cases.ElementAt(test).Value, result, 0, $"The expected value is {cases.ElementAt(test).Value} but we got {result}");


        }
    }
}