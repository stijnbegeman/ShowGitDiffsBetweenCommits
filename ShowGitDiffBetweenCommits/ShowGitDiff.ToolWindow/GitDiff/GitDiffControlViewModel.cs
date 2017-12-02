using ShowGitDiff.Sdk.Validation;
using ShowGitDiff.ToolWindow.GitDiff.FileChanges;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShowGitDiff.ToolWindow.GitDiff
{
    public class GitDiffControlViewModel : IGitDiffControlViewModel
    {
        #region Private fields

        private readonly IFileChangesControlViewModel _fileChangesControlViewModel;

        #endregion

        #region Public properties

        public IFileChangesControlViewModel FileChangesViewModel
        {
            get
            {
                return _fileChangesControlViewModel;
            }
        }

        #endregion

        #region Constructors

        public GitDiffControlViewModel(IFileChangesControlViewModel fileChangesControlViewModel)
        {
            ValidationUtil.ValidateArgNotNull(fileChangesControlViewModel, "fileChangesControlViewModel");

            _fileChangesControlViewModel = fileChangesControlViewModel;
        }
        
        #endregion
    }
}
