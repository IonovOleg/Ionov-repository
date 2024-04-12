using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace test_lab2.tests
{
    [TestClass]
    public class PointTests
    {
        [TestMethod]
        public void TestDistanceToOX1()  //Нахождение расстояния от точки до оси ox
        {
    
            Point testPoint1 = new Point();
            testPoint1.Init(5, Math.PI / 4); // Угол 45 градусов (Pi/4)

            Point testPoint2 = new Point();
            testPoint2.Init(3, Math.PI / 2); // Угол 90 градусов (Pi/2)

            double distance1 = testPoint1.DistanceToOX();
            double expected1 = 5 * Math.Abs(Math.Sin(Math.PI / 4));
 
            double distance2 = testPoint2.DistanceToOX();
            double expected2 = 3;
           
            Assert.AreEqual(distance1, expected1);
            Assert.AreEqual(distance2, expected2);
   
        }
        [TestMethod]
        public void TestAddMethod1() //Нахождение суммы точек
        {

            Point testPoint1 = new Point();
            testPoint1.Init(5, Math.PI / 4); 

            Point testPoint2 = new Point();
            testPoint2.Init(3, Math.PI / 2); 

            Point sum = testPoint1.Add(testPoint2);
            double expected1 = 8;
            double expected2 = (Math.PI / 4 + Math.PI / 2) % (2 * Math.PI);
            Assert.AreEqual(sum.r, expected1);
            Assert.AreEqual(sum.fi, expected2);
        }
        [TestMethod]
        public void TestDistanceToOX2()  //Нахождение расстояния от точки до оси ox c дробными числами
        {

            Point testPoint1 = new Point();
            testPoint1.Init(5.34565, Math.PI / 4); 

            Point testPoint2 = new Point();
            testPoint2.Init(3.546657, Math.PI / 2); 

            double distance1 = testPoint1.DistanceToOX();
            double expected1 = 5.34565 * Math.Abs(Math.Sin(Math.PI / 4));

            double distance2 = testPoint2.DistanceToOX();
            double expected2 = 3.546657;

            Assert.AreEqual(distance1, expected1);
            Assert.AreEqual(distance2, expected2);

        }
        [TestMethod]
        public void TestAddMethod2() //Нахождение суммы точек с дробными числами
        {

            Point testPoint1 = new Point();
            testPoint1.Init(5.567668768, Math.PI / 4);

            Point testPoint2 = new Point();
            testPoint2.Init(3.678768978, Math.PI / 2);

            Point sum = testPoint1.Add(testPoint2);
            double expected1 = 9.246437746;
            double expected2 = (Math.PI / 4 + Math.PI / 2) % (2 * Math.PI);
            Assert.AreEqual(sum.r, expected1);
            Assert.AreEqual(sum.fi, expected2);
        }
        [TestMethod]
        public void TestDistanceToOX3()  //Нахождение расстояния от точки до оси ox c одним отрицательным числом
        {

            Point testPoint1 = new Point();
            testPoint1.Init(-5.34565, Math.PI / 4);

            Point testPoint2 = new Point();
            testPoint2.Init(-3.546657, Math.PI / 2);

            double distance1 = testPoint1.DistanceToOX();
            double expected1 = -5.34565 * Math.Abs(Math.Sin(Math.PI / 4));

            double distance2 = testPoint2.DistanceToOX();
            double expected2 = -3.546657;

            Assert.AreEqual(distance1, expected1);
            Assert.AreEqual(distance2, expected2);

        }
        [TestMethod]
        public void TestAddMethod3() //Нахождение суммы точек с одним отрицательным числом
        {

            Point testPoint1 = new Point();
            testPoint1.Init(-5.567668768, Math.PI / 4);

            Point testPoint2 = new Point();
            testPoint2.Init(3.678768978, Math.PI / 2);

            Point sum = testPoint1.Add(testPoint2);
            double expected1 = -1.88889979;
            double expected2 = (Math.PI / 4 + Math.PI / 2) % (2 * Math.PI);
            Assert.AreEqual(sum.r, expected1);
            Assert.AreEqual(sum.fi, expected2);
        }
        [TestMethod]
        public void TestDistanceToOX4()  //Нахождение расстояния от точки до оси ox c двумя отрицательными числами
        {

            Point testPoint1 = new Point();
            testPoint1.Init(-5.34565, -Math.PI / 4);

            Point testPoint2 = new Point();
            testPoint2.Init(-3.546657, -Math.PI / 2);

            double distance1 = testPoint1.DistanceToOX();
            double expected1 = -5.34565 * Math.Abs(Math.Sin(-Math.PI / 4));

            double distance2 = testPoint2.DistanceToOX();
            double expected2 = -3.546657;

            Assert.AreEqual(distance1, expected1);
            Assert.AreEqual(distance2, expected2);

        }
        [TestMethod]
        public void TestAddMethod4() //Нахождение суммы точек с двумя отрицательными числами
        {

            Point testPoint1 = new Point();
            testPoint1.Init(-5.567668768, -Math.PI / 4);

            Point testPoint2 = new Point();
            testPoint2.Init(-3.678768978, -Math.PI / 2);

            Point sum = testPoint1.Add(testPoint2);
            double expected1 = -9.246437746;
            double expected2 = (-Math.PI / 4 - Math.PI / 2) % (2 * Math.PI);
            Assert.AreEqual(sum.r, expected1);
            Assert.AreEqual(sum.fi, expected2);
        }
        [TestMethod]
        public void TestDistanceToOX5()  //Нахождение расстояния от точки до оси ox c нулевым значением
        {

            Point testPoint1 = new Point();
            testPoint1.Init(0, -Math.PI / 4);

            Point testPoint2 = new Point();
            testPoint2.Init(0, -Math.PI / 2);

            double distance1 = testPoint1.DistanceToOX();
            double expected1 = 0 * Math.Abs(Math.Sin(-Math.PI / 4));

            double distance2 = testPoint2.DistanceToOX();
            double expected2 = 0;

            Assert.AreEqual(distance1, expected1);
            Assert.AreEqual(distance2, expected2);

        }
        [TestMethod]
        public void TestAddMethod5() //Нахождение суммы точек с нулевым значением
        {

            Point testPoint1 = new Point();
            testPoint1.Init(0, Math.PI / 4);

            Point testPoint2 = new Point();
            testPoint2.Init(0, Math.PI / 2);

            Point sum = testPoint1.Add(testPoint2);
            double expected1 = 0;
            double expected2 = (Math.PI / 4 + Math.PI / 2) % (2 * Math.PI);
            Assert.AreEqual(sum.r, expected1);
            Assert.AreEqual(sum.fi, expected2);
        }
    }
}
