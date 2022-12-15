using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Estudo1
{
    public class Produto
    {
        public string Name;
        public int Amount;
        public double Price;
        public double Weight;
        public double TotalValueResource()
        {
            return Price * Amount;
        }
        public void AddAmount(int amount)
        {
            Amount += amount;
        }
        public void RemAmount(int remAmount)
        {
            Amount = Amount - remAmount;
        }
        public double TotaLWeight()
        {
            return Amount * Weight;
        }
        public override string ToString()
        {
            return Name
                + ", R$ "
                + Price.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + Amount.ToString("F2", CultureInfo.InvariantCulture)
                + " Unidades. "
                + TotaLWeight().ToString("F2", CultureInfo.InvariantCulture)
                + " Kg."
                + "Valor total em estoque (R$): "
                + TotalValueResource().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
    public class Triangulo
    {
        public double Largura;
        public double Altura;
        public double CalcArea()
        {
            return Largura * Altura;
        }
    }
}
