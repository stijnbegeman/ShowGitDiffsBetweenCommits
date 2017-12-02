using Autofac;
using ShowGitDiff.ToolWindow.GitDiff;
using ShowGitDiff.ToolWindow.GitDiff.FileChanges;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShowGitDiff.Modules
{
    public class ProductionModule : Module
    {
        public static IGitDiffControlViewModel CreateViewModel()
        {
            var module = new ProductionModule();

            var builder = new ContainerBuilder();

            builder.RegisterModule(module);

            var container = builder.Build();

            return container.Resolve<IGitDiffControlViewModel>();
        }


        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<GitDiffControlViewModel>().As<IGitDiffControlViewModel>().SingleInstance();
            builder.RegisterType<FileChangesControlViewModel>().As<IFileChangesControlViewModel>().SingleInstance();
        }
    }
}
