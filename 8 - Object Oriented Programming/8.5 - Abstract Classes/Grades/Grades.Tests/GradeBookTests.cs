using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Grades;

namespace Grades.Tests
{
    [TestClass]
    public class GradeBookTests
    {
        [TestMethod]
        public void ComputesHighestGrade()
        {
            GradeBook book = new GradeBook();
            book.AddGrade(10);
            book.AddGrade(90);

            GradeStatistics result = book.ComputeStatistics();
            Assert.AreEqual(90, result.HighestGrade);
        }

        [TestMethod]
        public void ComputesLowestGrade()
        {
            GradeBook book = new GradeBook();
            book.AddGrade(10);
            book.AddGrade(90);

            GradeStatistics result = book.ComputeStatistics();
            Assert.AreEqual(10, result.LowestGrade);
        }

        [TestMethod]
        public void ComputesAverageGrade()
        {
            GradeBook book = new GradeBook();
            book.AddGrade(91);
            book.AddGrade(89.5f);
            book.AddGrade(75);

            GradeStatistics result = book.ComputeStatistics();
            Assert.AreEqual(85.16, result.AverageGrade, 0.01);
        }

        [TestMethod]
        public void ComputesLetterGradeA()
        {
            GradeBook book = new GradeBook();
            book.AddGrade(91);
            book.AddGrade(89.5f);
            book.AddGrade(95);

            GradeStatistics result = book.ComputeStatistics();
            Assert.AreEqual("A", result.LetterGrade);
        }

        [TestMethod]
        public void ComputesLetterGradeB()
        {
            GradeBook book = new GradeBook();
            book.AddGrade(81);
            book.AddGrade(84);
            book.AddGrade(88);

            GradeStatistics result = book.ComputeStatistics();
            Assert.AreEqual("B", result.LetterGrade);
        }

        [TestMethod]
        public void ComputesLetterGradeC()
        {
            GradeBook book = new GradeBook();
            book.AddGrade(81.4f);
            book.AddGrade(71);
            book.AddGrade(73);

            GradeStatistics result = book.ComputeStatistics();
            Assert.AreEqual("C", result.LetterGrade);
        }

        [TestMethod]
        public void ComputesLetterGradeD()
        {
            GradeBook book = new GradeBook();
            book.AddGrade(60);
            book.AddGrade(60);
            book.AddGrade(60);

            GradeStatistics result = book.ComputeStatistics();
            Assert.AreEqual("D", result.LetterGrade);
        }

        [TestMethod]
        public void ComputesLetterGradeF()
        {
            GradeBook book = new GradeBook();
            book.AddGrade(42);
            book.AddGrade(25);
            book.AddGrade(0);

            GradeStatistics result = book.ComputeStatistics();
            Assert.AreEqual("F", result.LetterGrade);
        }
    }
}
