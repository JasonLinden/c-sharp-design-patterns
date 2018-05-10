namespace _01___Chain_of_Responsibility.Publication.Specification
{
    /// <summary>
    /// Defines the specification pattern interface.
    /// </summary>
    /// <typeparam name="T">Type of object specification applies to.</typeparam>
    public interface ISpecification<in T>
    {
        /// <summary>
        /// Checks if current specification is satisfied by passed expression.
        /// </summary>
        /// <param name="expression">Expression to check.</param>
        /// <returns>Result.</returns>
        bool IsSatisfiedBy(T expression);
    }
}
