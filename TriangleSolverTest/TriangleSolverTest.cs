using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Assignment02;

namespace TriangleSolverTest
{
    [TestFixture]
    public class TriangleSolverTest
    {
        String expected;
        String result;

        [Test]
        public void equilateralSuccessTest()
        {
            //1.Arrange
            expected = "Triangle is Equilateral";
            
            //2.Act
            result = Assignment02.TriangleSolver.Analyze(4, 4, 4);
            
            //3.Assert
            Assert.AreEqual(expected, result);

        }

        [Test]
        public void equilateralFailureTest()
        {
            //1.Arrange
            expected = "Triangle is Equilateral";

            //2.Act
            result = Assignment02.TriangleSolver.Analyze(4, 2, 4);

            //3.Assert
            Assert.AreNotEqual(expected, result);

        }

        [Test]
        public void isocelesSuccessTest()
        {
            //1.Arrange
            expected = "Triangle is Isoceles";

            //2.Act
            result = Assignment02.TriangleSolver.Analyze(4, 4, 6);

            //3.Assert
            Assert.AreEqual(expected, result);

        }

        [Test]
        public void isocelesFailureTest()
        {
            //1.Arrange
            expected = "Triangle is Isoceles";

            //2.Act
            result = Assignment02.TriangleSolver.Analyze(4, 8, 6);

            //3.Assert
            Assert.AreNotEqual(expected, result);

        }

        [Test]
        public void scaleneSuccessTest()
        {
            //1.Arrange
            expected = "Triangle is Scalene";

            //2.Act
            result = Assignment02.TriangleSolver.Analyze(4, 6, 8);

            //3.Assert
            Assert.AreEqual(expected, result);

        }

        [Test]
        public void scaleneFailureTest()
        {
            //1.Arrange
            expected = "Triangle is Scalene";

            //2.Act
            result = Assignment02.TriangleSolver.Analyze(4, 8, 8);

            //3.Assert
            Assert.AreNotEqual(expected, result);

        }

        [Test]
        public void isTriangleTest()
        {
            //1.Arrange
            expected = "Triangle is Equilateral";

            //2.Act
            result = Assignment02.TriangleSolver.Analyze(8, 8, 8);

            //3.Assert
            Assert.AreEqual(expected, result);

        }

        [Test]
        public void isNotTriangleTest()
        {
            //1.Arrange
            expected = "Input values do not form a triangle";

            //2.Act
            result = Assignment02.TriangleSolver.Analyze(1, 2, 8);

            //3.Assert
            Assert.AreEqual(expected, result);

        }
    }
}
