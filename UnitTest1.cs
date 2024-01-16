using Xunit;

namespace PersonligVerifiering.Tests
{
    public class PersonligInfoValidatorTests
    {
        [Fact]
        public void Validera_GiltigtPersonnummer_ReturnerarTrue()
        {
            // Given
            string personnummer = "8808214855";

            // When
            bool resultat = PersonligInfoValidator.Validera(personnummer);

            // Then
            Assert.True(resultat);
        }