using System;

namespace ITest.Framework
{
    [AttributeUsage( AttributeTargets.Method, AllowMultiple = false, Inherited = false )]
    public class SetUpAttribute : Attribute
    {
    }
}
