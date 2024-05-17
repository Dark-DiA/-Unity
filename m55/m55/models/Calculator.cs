using m55.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace m55.models
{
    internal static class Calculator
    {
        // Метод для расчета процентной ставки
        public static void CalculateInterest(ICalculateInterest account)
        {
            account.CalculateInterest();
        }
    }
}
