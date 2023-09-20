using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyserDemo;
using System;

namespace MoodAnalyserTestProject
{
    [TestClass]
    public class MoodAnalyserTestClass
    {
        [TestMethod]
        [DataRow("I am in happy mood", "happy")]
        [DataRow("I am in sad mood", "sad")]
        public void Given_Message_Should_Return_Mood(string msg, string expected)
        {

            ///AAA method
            ///Arranged
            MoodAnalyser moodAnalyser = new MoodAnalyser(msg);

            //Act
            string actual = moodAnalyser.Analyser();

            //Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        [DataRow(null, "happy")]
       
        public void Given_Message_Should_Return_Exception(string msg, string expected)
        {

            ///AAA method
            ///Arranged
            MoodAnalyser moodAnalyser = new MoodAnalyser(msg);

            //Act
            string actual = moodAnalyser.Analyser();

            //Assert
            Assert.AreEqual(expected, actual);

        }
    }
}
