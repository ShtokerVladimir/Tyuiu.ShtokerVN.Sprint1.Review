using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ShtokerVN.Sprint1.TaskReview.V7.Lib;

namespace Tyuiu.ShtokerVN.Sprint1.TaskReview.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckCalc()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 3;
            double wait = 28.753;
            var res = ds.TriangleArea(x, y);
            Assert.AreEqual(wait, res);





        }
    }
}
