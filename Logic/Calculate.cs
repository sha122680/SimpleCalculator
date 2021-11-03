using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class Calculate
    {
        public static float calc(int zahl1, int zahl2, OperatorEnum op)
        {
            switch (op)
            {
                case OperatorEnum.plus:
                    return zahl1 + zahl2;
                    break;
                case OperatorEnum.minus:
                    return zahl1 - zahl2;
                    break;
                case OperatorEnum.mal:
                    return zahl1 * zahl2;
                    break;
                case OperatorEnum.durch:
                    return zahl1 / zahl2;
                    break;
                default:
                    return 0;
                    break;
            }
        }
    }
}
