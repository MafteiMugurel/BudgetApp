using System;

namespace FinancialTools
{
    public class CalculatorBuget
    {
        // Calculeaza cat ramane (Venit - Cheltuieli)
        public decimal CalculeazaBalanta(decimal venituri, decimal cheltuieli)
        {
            return venituri - cheltuieli;
        }

        // Verifica daca esti pe minus
        public bool EsteAlerta(decimal balanta)
        {
            return balanta < 0;
        }
    }
}