
using System;
using System.Collections.Generic;
using System.Text;

namespace ITest.Framework
{
    [AttributeUsage( AttributeTargets.Method, AllowMultiple = false, Inherited = false )]
    public class TearDownAttribute : Attribute
    {

    }
}
