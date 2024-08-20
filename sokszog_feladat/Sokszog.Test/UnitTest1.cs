using sokszog_feldat;
using Xunit.Abstractions;

namespace Sokszog.Test
{
    public class SokszogTests
    {
        private readonly ITestOutputHelper output;

        public SokszogTests(ITestOutputHelper output) { 
            this.output = output;
        }

        [Fact]
        public void Haromszog_HeronKeplet_Test()
        {
            // Arrange
            var haromszog = new Háromszög(3);
            haromszog.oldalak[0] = 3;
            haromszog.oldalak[1] = 4;
            haromszog.oldalak[2] = 5;

            // Act
            double terulet = haromszog.terület();

            // Assert
            Assert.Equal(6, terulet, 2);

            output.WriteLine("Points: 10");
        }

        [Fact]
        public void Teglalap_TeruletSzamitas_Test()
        {
            // Arrange
            var teglalap = new Téglalap(4);
            teglalap.oldalak[0] = 5;
            teglalap.oldalak[1] = 3;
            teglalap.oldalak[2] = 5;
            teglalap.oldalak[3] = 3;

            // Act
            double terulet = teglalap.terület();

            // Assert
            Assert.Equal(15, terulet);
            output.WriteLine("Points: 10");
        }
    }
}