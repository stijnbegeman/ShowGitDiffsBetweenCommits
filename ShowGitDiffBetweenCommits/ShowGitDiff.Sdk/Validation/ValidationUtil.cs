using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShowGitDiff.Sdk.Validation
{
    public static class ValidationUtil
    {

        public static void ValidateArgNotNull(object obj, string name)
        {
            if(obj == null)
            {
                throw new ArgumentNullException("Argument " + name + " cannot be null");
            }
        }
    }
}
