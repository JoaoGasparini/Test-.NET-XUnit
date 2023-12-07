using Alura.Estacionamento.Alura.Estacionamento.Modelos;
using Alura.Estacionamento.Modelos;
using Xunit;

namespace Alura.Estacionamento.Teste
{
    public class PatioTestes
    {
        [Fact]
        public void ValidaFaturamento()
        {
            //arrange
            Patio patio = new();
            Veiculo veiculo = new()
            {
                Proprietario = "João",
                //Tipo = TipoVeiculo.Automovel,
                Cor = "Verde",
                Modelo = "Fusca",
                Placa = "ASD-9999"
            };

            patio.RegistrarEntradaVeiculo(veiculo);
            patio.RegistrarSaidaVeiculo(veiculo.Placa);

            //act
            double faturamento = patio.TotalFaturado();

            //assert
            Assert.Equal(2, faturamento);
        }
        [Theory]
        [InlineData("André Silva", "ASD-9999", "PRETO", "GOL")]
        [InlineData("ROBERTO Silva", "DNS-8741", "CINZA", "FUSCA")]
        [InlineData("ANTONIO Silva", "GDR-1234", "AZUL", "OPALA")]
        public void ValidaFaturamentoComVariosVeiculos(string proprietario, string placa, string cor, string modelo)
        {
            //ARRANGE
            Patio Estacionamento = new();
            var veiculo = new Veiculo();

            veiculo.Proprietario = proprietario;
            veiculo.Placa = placa;
            veiculo.Cor = cor;
            veiculo.Modelo = modelo;

            Estacionamento.RegistrarEntradaVeiculo(veiculo);
            Estacionamento.RegistrarSaidaVeiculo(veiculo.Placa);

            //ACT
            double faturamento = Estacionamento.TotalFaturado();

            //ASSERT
            Assert.Equal(2, faturamento);
        }
    }
}
