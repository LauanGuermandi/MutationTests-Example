namespace MutationTestsExample.UnitTests;

public class PersonTests
{
    const string PersonName = "Lauan Guermandi";
    const int PersonAge = 31;

    [Fact]
    public void ShouldConstructPersonCorrectly()
    {
        // Arrange & Act
        var person = new Person(PersonName, PersonAge);

        // Assert
        Assert.NotEqual(person.Id, Guid.Empty);
        Assert.Equal(PersonName, person.Name);
        Assert.Equal(PersonAge, person.Age);
    }

    [Theory]
    [InlineData(17, false)]
    [InlineData(18, true)]
    [InlineData(20, true)]
    public void ShouldValidatePersonAgeCorrectly(int age, bool isOfLegalPerson)
    {
        // Arrange
        var person = new Person(PersonName, age);

        // Act & Assert
        Assert.Equal(isOfLegalPerson, person.IsOfLegalPerson());
    }
}