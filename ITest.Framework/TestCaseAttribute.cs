using System;

namespace ITest.Framework
{
    [AttributeUsage( AttributeTargets.Method, AllowMultiple = true, Inherited = false )]
    public class TestCaseAttribute : Attribute
    {
        /// <summary>
        /// Construct a TestCaseAttribute with a list of arguments. This constructor is not
        /// CLS-Compliant
        /// </summary>
        /// <param name="arguments">The value objects.</param>
        public TestCaseAttribute( params object[] arguments )
        {
            Arguments = arguments;
        }

        /// <summary>
        /// Gets or sets a value indicating whether this NUnit.Framework.TestCaseAttribute
        /// is explicit.
        /// </summary>
        public bool Explicit { get; set; }

        /// <summary>
        /// Gets or sets the test author.
        /// </summary>
        public string Author { get; set; }


        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets the list of arguments to a test case. 
        /// </summary>
        public object[] Arguments { get; }

    }
}
