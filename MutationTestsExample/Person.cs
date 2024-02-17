namespace MutationTestsExample;

public class Person(string name, int age)
{
    public Guid Id { get; } = Guid.NewGuid();
    public string Name { get; } = name;
    public int Age { get; } = age;

    public bool IsOfLegalPerson() => Age >= 18;
}
