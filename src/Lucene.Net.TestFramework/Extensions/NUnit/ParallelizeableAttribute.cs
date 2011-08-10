﻿// -----------------------------------------------------------------------
// <copyright file="ParallelizeableAttribute.cs" company="Microsoft">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace Lucene.Net.Extensions.NUnit
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    /// <summary>
    /// Placeholder for parallelizable tests in NUnit.
    /// </summary>
    [AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class | AttributeTargets.Method)]
    public class ParallelizableAttribute : System.Attribute
    {
        public TestScope Scope { get; set; }

        public int Order { get; set; }

        public ParallelizableAttribute()
        {
            
        }


        public ParallelizableAttribute(TestScope scope)
        {
            this.Scope = scope;
        }
    }
}