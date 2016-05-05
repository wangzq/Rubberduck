using System;
using Microsoft.Vbe.Interop;
using System.Linq;

namespace Rubberduck.VBEditor
{
    /// <summary>
    /// Represents a VBComponent or a VBProject.
    /// </summary>
    public struct QualifiedModuleName
    {
        public static string GetProjectId(VBProject project)
        {
            if (project == null)
            {
                return string.Empty;
            }
            return string.IsNullOrEmpty(project.HelpFile) ? project.GetHashCode().ToString() : project.HelpFile;
        }

        public static string GetProjectId(Reference reference)
        {
            var projectName = reference.Name;
            var path = reference.FullPath;
            return new QualifiedModuleName(projectName, path, projectName).ProjectId;
        }

        public QualifiedModuleName(VBProject project)
        {
            _component = null;
            _componentName = null;
            _project = project;
            _projectName = project.Name;
            _documentName = string.Empty;
            _projectPath = string.Empty;
            _projectId = GetProjectId(project);
            _contentHashCode = 0;
        }

        public QualifiedModuleName(VBComponent component)
        {
            _project = null; // field is only assigned when the instance refers to a VBProject.

            _component = component;
            _componentName = component == null ? string.Empty : component.Name;
            _documentName = string.Empty;
            _project = component == null ? null : component.Collection.Parent;
            _projectName = _project == null ? string.Empty : _project.Name;
            _projectPath = string.Empty;
            _projectId = GetProjectId(_project);

            _contentHashCode = 0;
            if (component == null)
            {
                return;
            }

            var module = component.CodeModule;
            _contentHashCode = module.CountOfLines > 0
                // ReSharper disable once UseIndexedProperty
                ? module.get_Lines(1, module.CountOfLines).GetHashCode()
                : 0;
        }

        /// <summary>
        /// Creates a QualifiedModuleName for a built-in declaration.
        /// Do not use this overload for user declarations.
        /// </summary>
        public QualifiedModuleName(string projectName, string projectPath, string componentName)
        {
            _project = null;
            _projectName = projectName;
            _projectPath = projectPath;
            _projectId = (_projectName + ";" + _projectPath).GetHashCode().ToString();
            _componentName = componentName;
            _component = null;
            _documentName = string.Empty;
            _contentHashCode = 0;
        }

        public QualifiedMemberName QualifyMemberName(string member)
        {
            return new QualifiedMemberName(this, member);
        }

        private readonly VBComponent _component;
        public VBComponent Component { get { return _component; } }

        private readonly VBProject _project;
        public VBProject Project { get { return _project; } }

        private readonly int _contentHashCode;
        public int ContentHashCode { get { return _contentHashCode; } }

        private readonly string _projectId;
        public string ProjectId { get { return _projectId; } }

        private readonly string _componentName;
        public string ComponentName { get { return _componentName ?? string.Empty; } }

        public string Name { get { return ToString(); } }

        private readonly string _documentName;
        public string DocumentName
        {
            get
            {
                string DocName = "";
                try
                {
                    DocName = this.Project.FileName;
                }
                catch
                {
                }

                if (DocName.Length > 0)
                {
                    return DocName;
                }
                else
                {
                    VBComponent comp = this.Project.VBComponents.Item(1);
                    if (comp.Type == vbext_ComponentType.vbext_ct_Document && comp.Properties.Count > 1)
                    {
                        Property prop = null;
                        try
                        {
                            prop = comp.Properties.Item("Name");
                        }
                        catch
                        {
                        }
                        DocName = (prop != null) ? prop.Value.ToString() : "";
                    }
                    return DocName;
                }
            }
        }
            
        private readonly string _projectName;

        public string ProjectName
        {
            get
            {
                return _projectName;
            }
        }
        private readonly string _projectPath;

        public string ProjectPath
        {
            get
            {
                return _projectPath;
            }
        }

        public override string ToString()
        {
            return _component == null && string.IsNullOrEmpty(_projectName)
                ? string.Empty
                : (string.IsNullOrEmpty(_projectPath) ? string.Empty : System.IO.Path.GetFileName(_projectPath) + ";")
                     + _projectName + "." + _componentName;
        }

        public override int GetHashCode()
        {
            unchecked
            {
                var hash = 17;
                hash = hash * 23 + _projectId.GetHashCode();
                hash = hash * 23 + (_componentName ?? string.Empty).GetHashCode();
                return hash;
            }
        }

        public override bool Equals(object obj)
        {
            if (obj == null) { return false; }

            try
            {
                var other = (QualifiedModuleName)obj;
                var result = other.ProjectId == ProjectId && other.ComponentName == ComponentName;
                return result;
            }
            catch (InvalidCastException)
            {
                return false;
            }
        }

        public static bool operator ==(QualifiedModuleName a, QualifiedModuleName b)
        {
            return a.Equals(b);
        }

        public static bool operator !=(QualifiedModuleName a, QualifiedModuleName b)
        {
            return !a.Equals(b);
        }
    }
}