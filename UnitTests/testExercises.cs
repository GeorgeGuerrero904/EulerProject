using EulerProject.Algorithms;
using System.Numerics;

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

        [DataRow(0)]
        [DataRow(1)]
        [TestMethod]
        public void EulerProject_8_returnsLong(int test)
        {
            //Arrange
            IDictionary<int, long> cases = new Dictionary<int, long>() {
                { 4, 5832 },
                { 13, 23514624000 }
            };
            //Act
            long res = _8.largestProductinaSeries(cases.ElementAt(test).Key);
            //Assert
            Assert.IsTrue(res == cases.ElementAt(test).Value, $"The expected value is {cases.ElementAt(test).Value} but we got {res}");
        }

        [DataRow(0)]
        [DataRow(1)]
        [DataRow(2)]
        [TestMethod]
        public void EulerProject_9_returnsLong(int test)
        {
            //Arrange
            IDictionary<int, long> cases = new Dictionary<int, long>() {
                { 24, 480 },
                { 120, 49920 },
                { 1000, 31875000 }
            };
            //Act
            long res = _9.specialPythagoreanTriplet(cases.ElementAt(test).Key);
            //Assert
            if (cases.ElementAt(test).Key == 120)
            {
                Assert.IsTrue(res == cases.ElementAt(test).Value || res == 60000, $"The expected value is {cases.ElementAt(test).Value} but we got {res}");
            }
            else
            {
                Assert.IsTrue(res == cases.ElementAt(test).Value, $"The expected value is {cases.ElementAt(test).Value} but we got {res}");
            }
        }
        [DataRow(0)]
        [DataRow(1)]
        [DataRow(2)]
        //[DataRow(3)] - commenting due it takes 125 minutes to complete
        [TestMethod]
        public void EulerProject_10_returnsLong(int test)
        {
            //Arrange
            IDictionary<int, long> cases = new Dictionary<int, long>() {
                { 17, 41},
                { 2001, 277050 },
                { 140759, 873608362 },
                { 2000000, 142913828922 }
            };
            //Act
            long res = _10.primeSummation(cases.ElementAt(test).Key);
            //Assert
            Assert.IsTrue(res == cases.ElementAt(test).Value, $"The expected value is {cases.ElementAt(test).Value} but we got {res}");
        }

        [DataRow(0)]
        [DataRow(1)]
        [TestMethod]
        public void EulerProject_11_returnsLong(int test)
        {
            //Arrange
            IDictionary<int[,], long> cases = new Dictionary<int[,], long>() {
            { new int[,]{
            {8,  2,  22, 97, 38, 15, 0,  40, 0,  75, 4,  5,  7,  78, 52, 12, 50, 77, 91, 8 },
            {49, 49, 99, 40, 17, 81, 18, 57, 60, 87, 17, 40, 98, 43, 69, 48, 4,  56, 62, 0 },
            {81, 49, 31, 73, 55, 79, 14, 29, 93, 71, 40, 67, 53, 88, 30, 3,  49, 13, 36, 65 },
            {52, 70, 95, 23, 4,  60, 11, 42, 69, 24, 68, 56, 1,  32, 56, 71, 37, 2,  36, 91 },
            {22, 31, 16, 71, 51, 67, 63, 89, 41, 92, 36, 54, 22, 40, 40, 28, 66, 33, 13, 80 },
            {24, 47, 32, 60, 99, 3,  45, 2,  44, 75, 33, 53, 78, 36, 84, 20, 35, 17, 12, 50 },
            {32, 98, 81, 28, 64, 23, 67, 10, 26, 38, 40, 67, 59, 54, 70, 66, 18, 38, 64, 70 },
            {67, 26, 20, 68, 2,  62, 12, 20, 95, 63, 94, 39, 63, 8,  40, 91, 66, 49, 94, 21 },
            {24, 55, 58, 5,  66, 73, 99, 26, 97, 17, 78, 78, 96, 83, 14, 88, 34, 89, 63, 72 },
            {21, 36, 23, 9,  75, 0,  76, 44, 20, 45, 35, 14, 0,  61, 33, 97, 34, 31, 33, 95 },
            {78, 17, 53, 28, 22, 75, 31, 67, 15, 94, 3,  80, 4,  62, 16, 14, 9,  53, 56, 92 },
            {16, 39, 5,  42, 96, 35, 31, 47, 55, 58, 88, 24, 0,  17, 54, 24, 36, 29, 85, 57 },
            {86, 56, 0,  48, 35, 71, 89, 7,  5,  44, 44, 37, 44, 60, 21, 58, 51, 54, 17, 58 },
            {19, 80, 81, 68, 5,  94, 47, 69, 28, 73, 92, 13, 86, 52, 17, 77, 4,  89, 55, 40 },
            {4,  52, 8,  83, 97, 35, 99, 16, 7,  97, 57, 32, 16, 26, 26, 79, 33, 27, 98, 66 },
            {88, 36, 68, 87, 57, 62, 20, 72, 3,  46, 33, 67, 46, 55, 12, 32, 63, 93, 53, 69 },
            {4,  42, 16, 73, 38, 25, 39, 11, 24, 94, 72, 18, 8,  46, 29, 32, 40, 62, 76, 36 },
            {20, 69, 36, 41, 72, 30, 23, 88, 34, 62, 99, 69, 82, 67, 59, 85, 74, 4,  36, 16 },
            {20, 73, 35, 29, 78, 31, 90, 1,  74, 31, 49, 71, 48, 86, 81, 16, 23, 57, 5, 54 },
            { 1, 70, 54, 71, 83, 51, 54, 69, 16, 92, 33, 48, 61, 43, 52, 1,  89, 19, 67, 48 }}, 70600674},
            { new int[,] {
            {40, 17, 81, 18, 57},
            {74, 4,  36, 16, 29},
            {36, 42, 69, 73, 45},
            {51, 54, 69, 16, 92},
            {7,  97, 57, 32, 16}
             }, 14169081 }
            };
            //Act
            long res = _11.largestGridProduct(cases.ElementAt(test).Key);

            //Assert
            Assert.IsTrue(res == cases.ElementAt(test).Value, $"The expected value is {cases.ElementAt(test).Value} but we got {res}");
        }


        [DataRow(0)]
        [DataRow(1)]
        [DataRow(2)]
        [DataRow(3)]
        [DataRow(4)]
        [TestMethod]
        public void EulerProject_12_returnsInt(int test)
        {
            //Arrange
            IDictionary<int, int> cases = new Dictionary<int, int>() {
                { 5, 28},
                { 23, 630},
                { 167, 1385280 },
                { 374, 17907120 },
                { 500, 76576500}
            };

            //Act
            int res = _12.divisibleTriangleNumber(cases.ElementAt(test).Key);

            //Assert
            Assert.IsTrue(res == cases.ElementAt(test).Value, $"The expected value is {cases.ElementAt(test).Value} but we got {res}");
        }

        [DataRow(0)]
        [DataRow(1)]
        [TestMethod]
        public void EulerProject_13_returnsLong(int test)
        {
            //Arrange
            IDictionary<string[], long> cases = new Dictionary<string[], long>() {
                { new string[]{"37107287533902102798797998220837590246510135740250", "46376937677490009712648124896970078050417018260538" }, 8348422521 },
                { new string[]
                {
                    "37107287533902102798797998220837590246510135740250",
                    "46376937677490009712648124896970078050417018260538",
                    "74324986199524741059474233309513058123726617309629",
                    "91942213363574161572522430563301811072406154908250",
                    "23067588207539346171171980310421047513778063246676",
                    "89261670696623633820136378418383684178734361726757",
                    "28112879812849979408065481931592621691275889832738",
                    "44274228917432520321923589422876796487670272189318",
                    "47451445736001306439091167216856844588711603153276",
                    "70386486105843025439939619828917593665686757934951",
                    "62176457141856560629502157223196586755079324193331",
                    "64906352462741904929101432445813822663347944758178",
                    "92575867718337217661963751590579239728245598838407",
                    "58203565325359399008402633568948830189458628227828",
                    "80181199384826282014278194139940567587151170094390",
                    "35398664372827112653829987240784473053190104293586",
                    "86515506006295864861532075273371959191420517255829",
                    "71693888707715466499115593487603532921714970056938",
                    "54370070576826684624621495650076471787294438377604",
                    "53282654108756828443191190634694037855217779295145",
                    "36123272525000296071075082563815656710885258350721",
                    "45876576172410976447339110607218265236877223636045",
                    "17423706905851860660448207621209813287860733969412",
                    "81142660418086830619328460811191061556940512689692",
                    "51934325451728388641918047049293215058642563049483",
                    "62467221648435076201727918039944693004732956340691",
                    "15732444386908125794514089057706229429197107928209",
                    "55037687525678773091862540744969844508330393682126",
                    "18336384825330154686196124348767681297534375946515",
                    "80386287592878490201521685554828717201219257766954",
                    "78182833757993103614740356856449095527097864797581",
                    "16726320100436897842553539920931837441497806860984",
                    "48403098129077791799088218795327364475675590848030",
                    "87086987551392711854517078544161852424320693150332",
                    "59959406895756536782107074926966537676326235447210",
                    "69793950679652694742597709739166693763042633987085",
                    "41052684708299085211399427365734116182760315001271",
                    "65378607361501080857009149939512557028198746004375",
                    "35829035317434717326932123578154982629742552737307",
                    "94953759765105305946966067683156574377167401875275",
                    "88902802571733229619176668713819931811048770190271",
                    "25267680276078003013678680992525463401061632866526",
                    "36270218540497705585629946580636237993140746255962",
                    "24074486908231174977792365466257246923322810917141",
                    "91430288197103288597806669760892938638285025333403",
                    "34413065578016127815921815005561868836468420090470",
                    "23053081172816430487623791969842487255036638784583",
                    "11487696932154902810424020138335124462181441773470",
                    "63783299490636259666498587618221225225512486764533",
                    "67720186971698544312419572409913959008952310058822",
                    "95548255300263520781532296796249481641953868218774",
                    "76085327132285723110424803456124867697064507995236",
                    "37774242535411291684276865538926205024910326572967",
                    "23701913275725675285653248258265463092207058596522",
                    "29798860272258331913126375147341994889534765745501",
                    "18495701454879288984856827726077713721403798879715",
                    "38298203783031473527721580348144513491373226651381",
                    "34829543829199918180278916522431027392251122869539",
                    "40957953066405232632538044100059654939159879593635",
                    "29746152185502371307642255121183693803580388584903",
                    "41698116222072977186158236678424689157993532961922",
                    "62467957194401269043877107275048102390895523597457",
                    "23189706772547915061505504953922979530901129967519",
                    "86188088225875314529584099251203829009407770775672",
                    "11306739708304724483816533873502340845647058077308",
                    "82959174767140363198008187129011875491310547126581",
                    "97623331044818386269515456334926366572897563400500",
                    "42846280183517070527831839425882145521227251250327",
                    "55121603546981200581762165212827652751691296897789",
                    "32238195734329339946437501907836945765883352399886",
                    "75506164965184775180738168837861091527357929701337",
                    "62177842752192623401942399639168044983993173312731",
                    "32924185707147349566916674687634660915035914677504",
                    "99518671430235219628894890102423325116913619626622",
                    "73267460800591547471830798392868535206946944540724",
                    "76841822524674417161514036427982273348055556214818",
                    "97142617910342598647204516893989422179826088076852",
                    "87783646182799346313767754307809363333018982642090",
                    "10848802521674670883215120185883543223812876952786",
                    "71329612474782464538636993009049310363619763878039",
                    "62184073572399794223406235393808339651327408011116",
                    "66627891981488087797941876876144230030984490851411",
                    "60661826293682836764744779239180335110989069790714",
                    "85786944089552990653640447425576083659976645795096",
                    "66024396409905389607120198219976047599490197230297",
                    "64913982680032973156037120041377903785566085089252",
                    "16730939319872750275468906903707539413042652315011",
                    "94809377245048795150954100921645863754710598436791",
                    "78639167021187492431995700641917969777599028300699",
                    "15368713711936614952811305876380278410754449733078",
                    "40789923115535562561142322423255033685442488917353",
                    "44889911501440648020369068063960672322193204149535",
                    "41503128880339536053299340368006977710650566631954",
                    "81234880673210146739058568557934581403627822703280",
                    "82616570773948327592232845941706525094512325230608",
                    "22918802058777319719839450180888072429661980811197",
                    "77158542502016545090413245809786882778948721859617",
                    "72107838435069186155435662884062257473692284509516",
                    "20849603980134001723930671666823555245252804609722",
                    "53503534226472524250874054075591789781264330331690",
                } , 5537376230}
            };
            //Act
            long res = _13.largeSum(cases.ElementAt(test).Key);

            //Assert
            Assert.IsTrue(res == cases.ElementAt(test).Value, $"The expected value is {cases.ElementAt(test).Value} but we got {res}");
        }


        [DataRow(0)]
        [DataRow(1)]
        [DataRow(2)]
        [DataRow(3)]
        [DataRow(4)]
        [TestMethod]
        public void EulerProject_14_returnsInt(int test)
        {
            //Arrange
            IDictionary<int, int> cases = new Dictionary<int, int>() {
                { 14, 9 },
                { 5847, 3711 },
                { 46500, 35655 },
                { 54512, 52527 },
                { 100000, 77031 },
                { 1000000, 837799 }
            };
            //Act
            int res = _14.longestCollatzSequence(cases.ElementAt(test).Key);

            //Assert
            Assert.IsTrue(res == cases.ElementAt(test).Value, $"The expected value is {cases.ElementAt(test).Value} but we got {res}");
        }

        [DataRow(0)]
        [DataRow(1)]
        [DataRow(2)]
        [TestMethod]
        public void EulerProject_15_returnsBigInteger(int test)
        {
            //Arrange
            IDictionary<int, long> cases = new Dictionary<int, long>() {
                { 4, 70 },
                { 9, 48620},
                {20, 137846528820  }
            };

            //Act
            BigInteger res = _15.latticePaths(cases.ElementAt(test).Key);

            //Assert
            Assert.IsTrue(res == cases.ElementAt(test).Value, $"The expected value is {cases.ElementAt(test).Value} but we got {res}");
        }

        [DataRow(0)]
        [DataRow(1)]
        [DataRow(2)]
        [TestMethod]
        public void EulerProject_16_returnsInt(int test)
        {  //Arrange
            IDictionary<int, int> cases = new Dictionary<int, int>() {
                { 15, 26 },
                { 128, 166},
                {1000, 1366  }
            };
            //Act
            int res = _16.powerDigitSum(cases.ElementAt(test).Key);

            //Assert
            Assert.IsTrue(res == cases.ElementAt(test).Value, $"The expected value is {cases.ElementAt(test).Value} but we got {res}");

        }


        [DataRow(0)]
        [DataRow(1)]
        [DataRow(2)]
        [TestMethod]
        public void EulerProject_17_returnsInt(int test)
        {  //Arrange
            IDictionary<int, int> cases = new Dictionary<int, int>() {
                { 5, 19},
                { 150, 1903},
                { 1000, 21124}
            };
            //Act
            int res = _17.numberLetterCounts(cases.ElementAt(test).Key);

            //Assert
            Assert.IsTrue(res == cases.ElementAt(test).Value, $"The expected value is {cases.ElementAt(test).Value} but we got {res}");
        }

        [DataRow(0)]
        [DataRow(1)]
        [TestMethod]
        public void EulerProject_18_returnsInt(int test)
        {
            //Arrange
            IDictionary<int[,], int> cases = new Dictionary<int[,], int>() {
                { new int[,]{
                    { 3, 0, 0, 0 },
                    { 7, 4, 0, 0 },
                    { 2, 4, 6, 0 },
                    { 8, 5, 9, 3 }
                }, 23},
                { new int[,] {
                    {75, 0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0},
                    {95, 64, 0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0},
                    {17, 47, 82, 0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0},
                    {18, 35, 87, 10, 0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0},
                    {20, 4,  82, 47, 65, 0,  0,  0,  0,  0,  0,  0,  0,  0,  0},
                    {19, 1,  23, 75, 3,  34, 0,  0,  0,  0,  0,  0,  0,  0,  0},
                    {88, 2,  77, 73, 7,  63, 67, 0,  0,  0,  0,  0,  0,  0,  0},
                    {99, 65, 4,  28, 6,  16, 70, 92, 0,  0,  0,  0,  0,  0,  0},
                    {41, 41, 26, 56, 83, 40, 80, 70, 33, 0,  0,  0,  0,  0,  0},
                    {41, 48, 72, 33, 47, 32, 37, 16, 94, 29, 0,  0,  0,  0,  0},
                    {53, 71, 44, 65, 25, 43, 91, 52, 97, 51, 14, 0,  0,  0,  0},
                    {70, 11, 33, 28, 77, 73, 17, 78, 39, 68, 17, 57, 0,  0,  0},
                    {91, 71, 52, 38, 17, 14, 91, 43, 58, 50, 27, 29, 48, 0,  0},
                    {63, 66, 4,  68, 89, 53, 67, 30, 73, 16, 69, 87, 40, 31, 0},
                    {4,  62, 98, 27, 23, 9,  70, 98, 73, 93, 38, 53, 60, 4, 23}
                }, 1074}
            };

            //Act
            int res = _18.maximumPathSumI(cases.ElementAt(test).Key);

            //Assert

        }
        [DataRow(0)]
        [DataRow(1)]
        [DataRow(2)]
        [TestMethod]
        public void EulerProject_19_returnsInt(int test)
        {

            //Arrange
            IDictionary<int[], int> cases = new Dictionary<int[], int>() {
                { new int[]{ 1943, 1946}, 6},
                { new int[]{ 1995, 2000}, 10},
                { new int[]{ 1901, 2000}, 171}
            };
            //Act
            int res = _19.countingSundays(cases.ElementAt(test).Key[0], cases.ElementAt(test).Key[1]);

            //Assert
            Assert.IsTrue(res == cases.ElementAt(test).Value, $"The expected value is {cases.ElementAt(test).Value} but we got {res}");

        }

        [DataRow(0)]
        [DataRow(1)]
        [DataRow(2)]
        [DataRow(3)]
        [DataRow(4)]
        [TestMethod]
        public void EulerProject_20_returnsInt(int test)
        {
            //Arrange
            IDictionary<int, int> cases = new Dictionary<int, int>() {
                { 10, 27},
                { 25, 72},
                { 50, 216},
                { 75, 432},
                { 100, 648}
            };

            //Act
            int res = _20.sumFactorialDigits(cases.ElementAt(test).Key);

            //Assert
            Assert.IsTrue(res == cases.ElementAt(test).Value, $"The expected value is {cases.ElementAt(test).Value} but we got {res}");

        }
        [DataRow(0)]
        [DataRow(1)]
        [DataRow(2)]
        [DataRow(3)]
        [TestMethod]
        public void EulerProject_21_returnsInt(int test)
        {
            //Arrange
            IDictionary<int, int> cases = new Dictionary<int, int>() {
                { 1000, 504},
                { 2000, 2898},
                { 5000, 8442},
                { 10000, 31626}
            };
            //Act
            int res = _21.sumAmicableNum(cases.ElementAt(test).Key);

            //Assert
            Assert.IsTrue(res == cases.ElementAt(test).Value, $"The expected value is {cases.ElementAt(test).Value} but we got {res}");


        }

        [DataRow(0)]
        [DataRow(1)]
        [TestMethod]
        public void EulerProject_22_returnsInt(int test)
        {
            //Arrange
            IDictionary<string[], int> cases = new Dictionary<string[], int>() {
                { new string[]{ "THIS", "IS", "ONLY", "A", "TEST" }, 791},
                { new string[]{ "I", "REPEAT", "THIS", "IS", "ONLY", "A", "TEST" }, 1468}
            };

            //Act
            int res = _22.namesScores(cases.ElementAt(test).Key);

            //Assert
            Assert.IsTrue(res == cases.ElementAt(test).Value, $"The expected value is {cases.ElementAt(test).Value} but we got {res}");
        }


        [DataRow(0)]
        [DataRow(1)]
        [DataRow(2)]
        [DataRow(3)]
        [TestMethod]
        public void EulerProject_23_returnsInt(int test)
        {
            //Arrange
            IDictionary<int, int> cases = new Dictionary<int, int>() {
                { 10000, 3731004},
                { 15000, 4039939},
                { 20000, 4159710},
                { 28123, 4179871}
            };
            //Act
            int res = _23.sumOfNonAbundantNumbers(cases.ElementAt(test).Key);

            //Assert
            Assert.IsTrue(res == cases.ElementAt(test).Value, $"The expected value is {cases.ElementAt(test).Value} but we got {res}");

        }

        [DataRow(0)]
        [DataRow(1)]
        [DataRow(2)]
        [DataRow(3)]
        [TestMethod]
        public void EulerProject_24_returnsLong(int test)
        {
            //Arrange
            IDictionary<int, long> cases = new Dictionary<int, long>() {
                { 699999, 1938246570},
                { 899999, 2536987410},
                { 900000, 2537014689},
                { 999999, 2783915460}
            };

            //Act
            long res = _24.lexicographicPermutations(cases.ElementAt(test).Key);

            //Assert
            Assert.IsTrue(res == cases.ElementAt(test).Value, $"The expected value is {cases.ElementAt(test).Value} but we got {res}");

        }


        [DataRow(0)]
        [DataRow(1)]
        [DataRow(2)]
        [DataRow(3)]
        [TestMethod]
        public void EulerProject_25_returnsInt(int test)
        {
            //Arrange
            IDictionary<int, int> cases = new Dictionary<int, int>() {
                { 5, 21},
                { 10, 45},
                { 15, 69},
                { 20, 93}
            };
            //Act
            int res = _25.digitFibonacci(cases.ElementAt(test).Key);

            //Assert
            Assert.IsTrue(res == cases.ElementAt(test).Value, $"The expected value is {cases.ElementAt(test).Value} but we got {res}");

        }



        [DataRow(0)]
        [DataRow(1)]
        [DataRow(2)]
        [DataRow(3)]
        [TestMethod]
        public void EulerProject_26_returnsInt(int test)
        {
            //Arrange
            IDictionary<int, int> cases = new Dictionary<int, int>() {
                { 700, 659},
                { 800, 743},
                { 900, 887},
                { 1000, 983}
            };

            //Act
            int res = _26.reciprocalCycles(cases.ElementAt(test).Key);

            //Assert
            Assert.IsTrue(res == cases.ElementAt(test).Value, $"The expected value is {cases.ElementAt(test).Value} but we got {res}");


        }

        [DataRow(0)]
        [DataRow(1)]
        [DataRow(2)]
        [DataRow(3)]
        [TestMethod]
        public void EulerProject_27_returnsInt(int test)
        {
            //Arrange
            IDictionary<int, int> cases = new Dictionary<int, int>() {
                { 200, -4925},
                { 500, -18901},
                { 800, -43835},
                { 1000, -59231}
            };
            //Act
            int res = _27.quadraticPrimes(cases.ElementAt(test).Key);

            //Assert
            Assert.IsTrue(res == cases.ElementAt(test).Value, $"The expected value is {cases.ElementAt(test).Value} but we got {res}");

        }
    }
}