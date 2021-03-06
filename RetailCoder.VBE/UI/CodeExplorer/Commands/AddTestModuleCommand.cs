using System.Runtime.InteropServices;
using Microsoft.Vbe.Interop;
using NLog;
using Rubberduck.Navigation.CodeExplorer;
using Rubberduck.Parsing.Symbols;
using Rubberduck.UI.Command;

namespace Rubberduck.UI.CodeExplorer.Commands
{
    [CodeExplorerCommand]
    public class AddTestModuleCommand : CommandBase
    {
        private readonly VBE _vbe;
        private readonly Command.AddTestModuleCommand _newUnitTestModuleCommand;

        public AddTestModuleCommand(VBE vbe, Command.AddTestModuleCommand newUnitTestModuleCommand) : base(LogManager.GetCurrentClassLogger())
        {
            _vbe = vbe;
            _newUnitTestModuleCommand = newUnitTestModuleCommand;
        }

        protected override bool CanExecuteImpl(object parameter)
        {
            try
            {
                return GetDeclaration(parameter) != null || _vbe.VBProjects.Count == 1;
            }
            catch (COMException)
            {
                return false;
            }
        }

        protected override void ExecuteImpl(object parameter)
        {
            _newUnitTestModuleCommand.Execute(parameter != null
                ? GetDeclaration(parameter).Project
                : _vbe.VBProjects.Item(1));
        }

        private Declaration GetDeclaration(object parameter)
        {
            var node = parameter as CodeExplorerItemViewModel;
            while (node != null && !(node is ICodeExplorerDeclarationViewModel))
            {
                node = node.Parent;
            }

            return node == null ? null : ((ICodeExplorerDeclarationViewModel)node).Declaration;
        }
    }
}
