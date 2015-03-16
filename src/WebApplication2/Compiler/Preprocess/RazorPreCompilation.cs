using System;
using Microsoft.AspNet.Mvc;

namespace WebApplication2.Compiler.Preprocess
{
    public class RazorPreCompilation : RazorPreCompileModule
    {
        public RazorPreCompilation(IServiceProvider provider) : base(provider)
        {
        }
    }
}
