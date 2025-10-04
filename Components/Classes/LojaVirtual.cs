using PadrãoStrategy.Components.Classes.Interface;
using PadrãoStrategy.Components.Pages;

namespace PadrãoStrategy.Components.Classes
{
    public class LojaVirtual
    {
        private CalcFrete calculadorFrete;
        

        // Injeção da estratégia pelo construtor
        public LojaVirtual(CalcFrete calculadorFrete)
        {
            this.calculadorFrete = calculadorFrete;
            
        }

        // Delegação para a estratégia
        public double calcularFrete(double peso, int qtdcaixa)
        {
            return calculadorFrete.calcular(peso, qtdcaixa);
        }



    }
}
