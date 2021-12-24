using System;
using DataAccess;
using Microsoft.VisualBasic.Logging;

namespace Logic
{
    public class Calculate
    {
        public int BerechnungID { get; set; }
        public string Berechnung { get; set; }

        public static float Calc(int zahl1, int zahl2, OperatorEnum op)
        {
            float resultValue = 0;
            var c = new Calculate();

            switch (op)
            {
                case OperatorEnum.plus:
                    resultValue = zahl1 + zahl2;
                    c.Berechnung = $"{zahl1} + {zahl2} = {resultValue}";
                    break;

                case OperatorEnum.minus:
                    resultValue = zahl1 - zahl2;
                    c.Berechnung = $"{zahl1} - {zahl2} = {resultValue}";
                    break;

                case OperatorEnum.mal:
                    resultValue = zahl1 * zahl2;
                    c.Berechnung = $"{zahl1} * {zahl2} = {resultValue}";
                    break;

                case OperatorEnum.durch:
                    resultValue = zahl1 / zahl2;
                    c.Berechnung = $"{zahl1} / {zahl2} = {resultValue}";
                    break;

                default:
                    return 0;
            }
            c.Save();
            return resultValue;
        }

        public void Save()
        {
            try
            {
                using (var context = new SimpleCalculatorEntities())
                {
                    var calc = context.Calculator.Add(MapLlToDa(this));
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {

            }
        }

        private Calculate MapDaToLl(Calculator c)
        {
            return new Calculate
            {
                BerechnungID = c.BerechnungID,
                Berechnung = c.Berechnung
            };
        }

        private Calculator MapLlToDa(Calculate c)
        {
            return new Calculator
            {
                BerechnungID = c.BerechnungID,
                Berechnung = c.Berechnung
            };
        }
    }
}