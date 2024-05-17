using m55.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace m55.models
{
    internal class SalaryAccount : ICalculateInterest
    {
        // баланс учетной записи
        public double Balance { get; set; }

        // процентная ставка
        public double Interest { get; set; }

        // Метод для расчета процентной ставки
        public void CalculateInterest()
        {
            // расчет процентной ставк зарплатного аккаунта по правилам банка
            Interest = Balance * 0.5;

            Console.WriteLine($"Тип аккаунта: зарплатный. Процентная ставка : {Interest}");

        }
    }
}
