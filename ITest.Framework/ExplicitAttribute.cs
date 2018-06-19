using System;

namespace ITest.Framework
{
    [AttributeUsage( AttributeTargets.Method|AttributeTargets.Class, AllowMultiple = false, Inherited = true )]
    public class ExplicitAttribute : Attribute
    {
    }
}
