using Alura.Estacionamento.Modelos;
using Xunit;

namespace Alura.Estacionamento.Teste
{
    public class VeiculoTestes
    {
        [Fact]
        [Trait("Funcionalidade", "Acelerar")]
        public void TestaVeiculoAcelerar()
        {
            //arrange
            Veiculo veiculo = new();
            //act
            veiculo.Acelerar(10);
            //assert
            Assert.Equal(100, veiculo.VelocidadeAtual);
        }

        [Fact]
        [Trait("Funcionalidade", "Frear")]
        public void TestaVeiculoFrear()
        {
            //arrange
            Veiculo veiculo = new();
            //act
            veiculo.Frear(10);
            //assert
            Assert.Equal(-150, veiculo.VelocidadeAtual);
        }

        [Fact(Skip = "Teste em desenvolvimento.")]
        public void ComoIgnorarTeste()
        {
            //MANEIRA DE IGNORAR O TESTE
        }

        [Fact(DisplayName = "Terceiro teste")]
        public void DisplayNameTeste()
        {
            //MANEIRA DE ADICIONAR NOME DO TESTE PERSONALIZADO EM VEZ DO METODO
        }

        [Fact(DisplayName = "Terceiro teste", Skip = "Pulando teste")]
        public void DisplayNameTestePulaTeste()
        {
            //MANEIRA DE ADICIONAR NOME DO TESTE PERSONALIZADO EM VEZ DO METODO E PULA TESTE
        }

        [Theory]
        [ClassData(typeof(Veiculo))]
        public void TestaVeiculoClass(Veiculo modelo)
        {
            //Arrange 
            var veiculo = new Veiculo();

            //Act 
            veiculo.Acelerar(10);
            modelo.Acelerar(10);

            //Assert 
            Assert.Equal(modelo.VelocidadeAtual, veiculo.VelocidadeAtual);
        }

    }
}
