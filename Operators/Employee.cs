// Create the Employee class with properties Id, FirstName, and LastName
public class Employee
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

    // Overload the "==" operator to compare Employee objects by their Id property
    public static bool operator ==(Employee employee1, Employee employee2)
    {
        if (ReferenceEquals(employee1, employee2))
        {
            return true; // If both references point to the same object, they are considered equal.
        }

        if (ReferenceEquals(employee1, null) || ReferenceEquals(employee2, null))
        {
            return false; // If one of the objects is null, they are not considered equal.
        }

        return employee1.Id == employee2.Id; // Compare the Id properties for equality.
    }

    // Overload the "!=" operator using the "==" operator to maintain consistency
    public static bool operator !=(Employee employee1, Employee employee2)
    {
        return !(employee1 == employee2); // Use the negation of the "=="" operator.
    }

    // Override the Equals() method for better comparison behavior
    public override bool Equals(object obj)
    {
        if (obj is Employee otherEmployee)
        {
            return this == otherEmployee; // Use the overloaded "==" operator for comparison.
        }

        return false;
    }

    // Override the GetHashCode() method to satisfy compiler warnings.
    public override int GetHashCode()
    {
        return Id.GetHashCode();
    }
}
