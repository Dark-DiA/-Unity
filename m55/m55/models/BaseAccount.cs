using m55.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace m55.models
{
    internal class BaseAccount : ICalculateInterest
    {
        // баланс учетной записи
        public double Balance { get; set; }

        // процентная ставка
        public double Interest { get; set; }

        // Метод для расчета процентной ставки
        public void CalculateInterest()
        {

            // расчет процентной ставки обычного аккаунта по правилам банка
            Interest = Balance * 0.4;

            if (Balance < 1000)
                Interest -= Balance * 0.2;

            if (Balance < 50000)
                Interest -= Balance * 0.4;

            Console.WriteLine($"Тип аккаунта: обычный. Процентная ставка : {Interest}");

        }
    }
}
