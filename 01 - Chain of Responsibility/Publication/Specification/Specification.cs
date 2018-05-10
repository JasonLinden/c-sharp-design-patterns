using System;

namespace _01___Chain_of_Responsibility.Publication.Specification
{
    /// <summary>
    /// Basic specification that checks if passed function expression is satisfied by other expressions.
    /// 
    /// Extensions will allow multiple expressions to be chained together.
    /// </summary>
    /// <typeparam name="T">Type of object specification applies to.</typeparam>
    public class Specification<T> : ISpecification<T>
    {
        private readonly Func<T, bool> _expression;
        public Specification(Func<T, bool> expression)
        {
            this._expression = expression;
        }

        public bool IsSatisfiedBy(T expression)
        {
            return this._expression(expression);
        }
    }
}
