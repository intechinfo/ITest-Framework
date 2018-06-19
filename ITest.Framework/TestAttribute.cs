using System;

namespace ITest.Framework
{
    //
    // Résumé :
    //     Adding this attribute to a method makes the method callable from the NUnit test
    //     runner.
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false, Inherited = true)]
    public class TestAttribute : Attribute
    {

        //
        // Résumé :
        //     Descriptive text for this test
        public string Description { get; set; }
        //
        // Résumé :
        //     The author of this test
        public string Author { get; set; }

    }
}
