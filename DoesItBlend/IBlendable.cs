using System;
using System.Collections.Generic;
using System.Text;

namespace DoesItBlend
{
    interface IBlendable
    {
        /// <summary>
        /// Blends the object
        /// </summary>
        /// <returns>A string describing the blended object</returns>
        string Blend();
    }
}
