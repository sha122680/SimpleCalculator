using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTest
{
    [TestClass]
    public class DataAccessCalculateTest
    {
        [TestMethod]
        public void CalculateSaveTest()
        {
            try
            {
                // Arrange
                var c = new DataAccess.Calculator
                {
                    Berechnung = "1 + 1 = 2"
                };

                // Act
                DataAccess.Calculator cSave;
                using (var context = new DataAccess.SimpleCalculatorEntities())
                {
                    cSave = context.Calculator.Add(c);
                    context.SaveChanges();
                }

                // Assert
                Assert.IsNotNull(cSave);
                Assert.IsTrue(cSave.BerechnungID > 1);
                Assert.AreEqual(cSave.Berechnung,"1 + 1 = 2");
            }
            catch (Exception e)
            {
                Assert.Fail(e.Message);
            }
        }

        [TestMethod]
        public void CalculateSaveNegativeTest()
        {
            try
            {
                // Arrange
                var c = new DataAccess.Calculator { };

                // Act
                DataAccess.Calculator cSave;
                using (var context = new DataAccess.SimpleCalculatorEntities())
                {
                    cSave = context.Calculator.Add(c);
                    context.SaveChanges();
                }

                // Assert
                Assert.Fail("");
            }
            catch (Exception e)
            {
                Assert.IsTrue(true);
            }
        }
    }
}
