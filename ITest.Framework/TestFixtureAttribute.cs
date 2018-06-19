using System;

namespace ITest.Framework
{
    //
    // Résumé :
    //     TestFixtureAttribute is used to mark a class that represents a TestFixture.
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true, Inherited = true)]
    public class TestFixtureAttribute : Attribute
    {
        /// <summary>
        /// Gets or sets the name of the test.
        /// </summary>
        public string TestName { get; set; }
        /// <summary>
        /// Descriptive text for this fixture
        /// </summary>
        public string Description { get; set; }   
        /// <summary>
        /// The author of this fixture
        /// </summary>
        public string Author { get; set; }
    }
}
