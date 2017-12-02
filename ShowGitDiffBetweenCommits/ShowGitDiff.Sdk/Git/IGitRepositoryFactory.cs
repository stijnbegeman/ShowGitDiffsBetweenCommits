using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShowGitDiff.Sdk.Git
{
    public interface IGitRepositoryFactory
    {
        IGitRepository CreateGitRepository(string url);
    }
}
