﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShowGitDiff.ToolWindow.GitDiff.FileChanges
{
    public interface IFileChangesControlViewModel
    {
        Task UpdateFileChanges();
    }
}
