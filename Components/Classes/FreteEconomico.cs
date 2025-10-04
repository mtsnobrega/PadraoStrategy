using PadrãoStrategy.Components.Classes.Interface;

namespace PadrãoStrategy.Components.Classes
{
    public class FreteEconomico : CalcFrete
    {
        private double ValorFrete = 15;
        private double ValorCaixa = 20;
        private double TotalCaixas;
        private double TotalPeso; 
        private double Excessoporkg = 0.75;
        private double ValorTotal;
        public double calcular(double peso, int qtdcaixa)
        {
            TotalCaixas = ValorCaixa * qtdcaixa;
            TotalPeso = peso * qtdcaixa;
            ValorTotal = ValorFrete + TotalCaixas + (Excessoporkg * TotalPeso);
            return ValorTotal;
        }
    }
}
