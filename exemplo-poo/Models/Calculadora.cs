using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using exemplo_poo.Interfaces;

namespace exemplo_poo.Models
{
    public class Calculadora : ICalculadora
    {
        public double Somar(double num1, double num2)
        {
            return num1 + num2;
        }

        public double Subtrair(double num1, double num2)
        {
            return num1 - num2;
        }
        
        public double Multiplicar(double num1, double num2)
        {
            return num1 * num2;
        }

    }
}