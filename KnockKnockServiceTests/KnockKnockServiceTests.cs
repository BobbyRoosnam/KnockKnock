using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using KnockKnockServiceTests.KnockKnockService;
using System.Collections;

namespace KnockKnockServiceTests
{
    [TestFixture]
    public class KnockKnockServiceTests
    {
        #region Set Up

            IRedPill service = new RedPillClient();
            [SetUp]
            public void Init()
            {
                service = new RedPillClient();
            }

        #endregion

        #region Fibonacci Tests

        public class FibonacciTest
            {
                public static IEnumerable Cases
                {
                    get
                    {
                        yield return new TestCaseData(0).Returns(0);
                        yield return new TestCaseData(1).Returns(1);
                        yield return new TestCaseData(2).Returns(1);
                        yield return new TestCaseData(3).Returns(2);
                        yield return new TestCaseData(4).Returns(3);
                        yield return new TestCaseData(5).Returns(5);
                        yield return new TestCaseData(6).Returns(8);
                        yield return new TestCaseData(7).Returns(13);
                        yield return new TestCaseData(8).Returns(21);
                        yield return new TestCaseData(9).Returns(34);
                        yield return new TestCaseData(10).Returns(55);
                        yield return new TestCaseData(11).Returns(89);
                        yield return new TestCaseData(12).Returns(144);
                        yield return new TestCaseData(13).Returns(233);
                        yield return new TestCaseData(14).Returns(377);
                        yield return new TestCaseData(15).Returns(610);
                        yield return new TestCaseData(16).Returns(987);
                        yield return new TestCaseData(17).Returns(1597);
                        yield return new TestCaseData(18).Returns(2584);
                        yield return new TestCaseData(19).Returns(4181);
                        yield return new TestCaseData(20).Returns(6765);
                        yield return new TestCaseData(21).Returns(10946);
                        yield return new TestCaseData(22).Returns(17711);
                        yield return new TestCaseData(23).Returns(28657);
                        yield return new TestCaseData(24).Returns(46368);
                        yield return new TestCaseData(25).Returns(75025);
                        yield return new TestCaseData(26).Returns(121393);
                        yield return new TestCaseData(27).Returns(196418);
                        yield return new TestCaseData(28).Returns(317811);
                        yield return new TestCaseData(29).Returns(514229);
                        yield return new TestCaseData(30).Returns(832040);
                        yield return new TestCaseData(31).Returns(1346269);
                        yield return new TestCaseData(32).Returns(2178309);
                        yield return new TestCaseData(33).Returns(3524578);
                        yield return new TestCaseData(34).Returns(5702887);
                        yield return new TestCaseData(35).Returns(9227465);
                        yield return new TestCaseData(36).Returns(14930352);
                        yield return new TestCaseData(37).Returns(24157817);
                        yield return new TestCaseData(38).Returns(39088169);
                        yield return new TestCaseData(39).Returns(63245986);
                        yield return new TestCaseData(40).Returns(102334155);
                        yield return new TestCaseData(41).Returns(165580141);
                        yield return new TestCaseData(42).Returns(267914296);
                        yield return new TestCaseData(43).Returns(433494437);
                        yield return new TestCaseData(44).Returns(701408733);
                        yield return new TestCaseData(45).Returns(1134903170);
                        yield return new TestCaseData(46).Returns(1836311903);
                        yield return new TestCaseData(47).Returns(2971215073);
                        yield return new TestCaseData(48).Returns(4807526976);
                        yield return new TestCaseData(49).Returns(7778742049);
                        yield return new TestCaseData(50).Returns(12586269025);
                        yield return new TestCaseData(51).Returns(20365011074);
                        yield return new TestCaseData(52).Returns(32951280099);
                        yield return new TestCaseData(53).Returns(53316291173);
                        yield return new TestCaseData(54).Returns(86267571272);
                        yield return new TestCaseData(55).Returns(139583862445);
                        yield return new TestCaseData(56).Returns(225851433717);
                        yield return new TestCaseData(57).Returns(365435296162);
                        yield return new TestCaseData(58).Returns(591286729879);
                        yield return new TestCaseData(59).Returns(956722026041);
                        yield return new TestCaseData(60).Returns(1548008755920);
                        yield return new TestCaseData(61).Returns(2504730781961);
                        yield return new TestCaseData(62).Returns(4052739537881);
                        yield return new TestCaseData(63).Returns(6557470319842);
                        yield return new TestCaseData(64).Returns(10610209857723);
                        yield return new TestCaseData(65).Returns(17167680177565);
                        yield return new TestCaseData(66).Returns(27777890035288);
                        yield return new TestCaseData(67).Returns(44945570212853);
                        yield return new TestCaseData(68).Returns(72723460248141);
                        yield return new TestCaseData(69).Returns(117669030460994);
                        yield return new TestCaseData(70).Returns(190392490709135);
                        yield return new TestCaseData(71).Returns(308061521170129);
                        yield return new TestCaseData(72).Returns(498454011879264);
                        yield return new TestCaseData(73).Returns(806515533049393);
                        yield return new TestCaseData(74).Returns(1304969544928657);
                        yield return new TestCaseData(75).Returns(2111485077978050);
                        yield return new TestCaseData(76).Returns(3416454622906707);
                        yield return new TestCaseData(77).Returns(5527939700884757);
                        yield return new TestCaseData(78).Returns(8944394323791464);
                        yield return new TestCaseData(79).Returns(14472334024676221);
                        yield return new TestCaseData(80).Returns(23416728348467685);
                        yield return new TestCaseData(81).Returns(37889062373143906);
                        yield return new TestCaseData(82).Returns(61305790721611591);
                        yield return new TestCaseData(83).Returns(99194853094755497);
                        yield return new TestCaseData(84).Returns(160500643816367088);
                        yield return new TestCaseData(85).Returns(259695496911122585);
                        yield return new TestCaseData(86).Returns(420196140727489673);
                        yield return new TestCaseData(87).Returns(679891637638612258);
                        yield return new TestCaseData(88).Returns(1100087778366101931);
                        yield return new TestCaseData(89).Returns(1779979416004714189);
                        yield return new TestCaseData(90).Returns(2880067194370816120);
                        yield return new TestCaseData(91).Returns(4660046610375530309);
                        yield return new TestCaseData(92).Returns(7540113804746346429);
                        //Negative numbers
                        yield return new TestCaseData(-0).Returns(0);
                        yield return new TestCaseData(-1).Returns(1);
                        yield return new TestCaseData(-2).Returns(-1);
                        yield return new TestCaseData(-3).Returns(2);
                        yield return new TestCaseData(-4).Returns(-3);
                        yield return new TestCaseData(-71).Returns(308061521170129);
                        yield return new TestCaseData(-80).Returns(-23416728348467685);
                        yield return new TestCaseData(-92).Returns(-7540113804746346429);
                    }
                }
            }

            [Test, TestCaseSource(typeof(FibonacciTest), "Cases")]
            public long FibonacciCase(long index)
            {
                return service.FibonacciNumber(index);
            }

        #endregion

        #region Shape Tests

            public class ShapeTest
            {
                public static IEnumerable Cases
                {
                    get
                    {
                        // Negatives
                        yield return new TestCaseData(-1, 1, -1).Returns(TriangleType.Error);
                        yield return new TestCaseData(-1, -1, 1).Returns(TriangleType.Error);
                        yield return new TestCaseData(-1, -1, -1).Returns(TriangleType.Error);
                        // Equilaterals
                        yield return new TestCaseData(1, 1, 1).Returns(TriangleType.Equilateral);
                        yield return new TestCaseData(10, 10, 10).Returns(TriangleType.Equilateral);
                        // Isosceles
                        yield return new TestCaseData(1, 2, 2).Returns(TriangleType.Isosceles);
                        yield return new TestCaseData(2, 1, 2).Returns(TriangleType.Isosceles);
                        // Isosceles - Equal sides are less or equal to than 3rd side
                        yield return new TestCaseData(2, 5, 2).Returns(TriangleType.Error);
                        yield return new TestCaseData(2, 2, 4).Returns(TriangleType.Error);
                        yield return new TestCaseData(2, 2, 5).Returns(TriangleType.Error);
                        // Scalenes
                        yield return new TestCaseData(6, 4, 3).Returns(TriangleType.Scalene);
                        yield return new TestCaseData(6, 3, 4).Returns(TriangleType.Scalene);
                        // Scalenes - Sides don't add up
                        yield return new TestCaseData(1, 2, 3).Returns(TriangleType.Error);
                        yield return new TestCaseData(3, 1, 2).Returns(TriangleType.Error);
                        yield return new TestCaseData(3, 2, 1).Returns(TriangleType.Error);
                        // Zeros
                        yield return new TestCaseData(0, 1, 1).Returns(TriangleType.Error);
                        yield return new TestCaseData(1, 0, 0).Returns(TriangleType.Error);
                        yield return new TestCaseData(1, 0, 1).Returns(TriangleType.Error);
                        yield return new TestCaseData(1, 1, 0).Returns(TriangleType.Error);
                    }
                }
            }

            [Test, TestCaseSource(typeof(ShapeTest), "Cases")]
            public TriangleType WhatShapeIsThisCase(int a, int b, int c)
            {
                return service.WhatShapeIsThis(a, b, c);
            }

        #endregion

        #region Word Tests

            public class ReverseWordsTest
            {
                public static IEnumerable Cases
                {
                    get
                    {

                        yield return new TestCaseData("").Returns("");
                        yield return new TestCaseData("hello").Returns("olleh");
                        yield return new TestCaseData("hello world").Returns("olleh dlrow");
                        yield return new TestCaseData("Hello!").Returns("!olleH");
                        yield return new TestCaseData("This Is A Long Sentence To Be Reversed").Returns("sihT sI A gnoL ecnetneS oT eB desreveR"); 
                        yield return new TestCaseData("-- Numbers -- Should -- Reverse -- As -- Well -- 1234 -- -4321 --").Returns(
                        "-- srebmuN -- dluohS -- esreveR -- sA -- lleW -- 4321 -- 1234- --");  
                    }
                }
            }

            [Test, TestCaseSource(typeof(ReverseWordsTest), "Cases")]
            public string ReverseWordsCase(string input)
            {
                return service.ReverseWords(input);
            }

        #endregion

    }
}
