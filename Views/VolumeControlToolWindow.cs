using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

using Microsoft.VisualStudio.Shell;
using QMediaVSIX.i18n;

namespace QMediaVSIX.Views {
    /// <summary>
    /// This class implements the tool window exposed by this package and hosts a user control.
    /// </summary>
    /// <remarks>
    /// In Visual Studio tool windows are composed of a frame (implemented by the shell) and a pane,
    /// usually implemented by the package implementer.
    /// <para>
    /// This class derives from the ToolWindowPane class provided from the MPF in order to use its
    /// implementation of the IVsUIElementPane interface.
    /// </para>
    /// </remarks>
    [Guid(WindowGuidString)]
    public sealed class VolumeControlToolWindow : ToolWindowPane {
        public const string WindowGuidString = "80b763a1-5bfa-448d-98ea-585a06ad940e";
        public const string Title = "Sample Volume Control";

        /// <summary>
        /// Initialises a new instance of the <see cref="VolumeControlToolWindow"/> class.
        /// </summary>
        public VolumeControlToolWindow() {
            Debug.WriteLine($"{nameof(VolumeControlToolWindow)}.cto();");
            Caption = "VolumeControlToolWindow";

            // This is the user control hosted by the tool window; Note that, even if this class implements IDisposable,
            // we are not calling Dispose on this object. This is because ToolWindowPane calls Dispose on
            // the object returned by the Content property.
            Content = new VolumeControlToolWindowControl();
        }

        public VolumeControlToolWindow(IServiceProvider ServiceProvider) : base(ServiceProvider) {
            Debug.WriteLine($"{nameof(VolumeControlToolWindow)}.cto({nameof(IServiceProvider)}); ({{0}}: {ServiceProvider})");
            Caption = "VolumeControlToolWindow";

            // This is the user control hosted by the tool window; Note that, even if this class implements IDisposable,
            // we are not calling Dispose on this object. This is because ToolWindowPane calls Dispose on
            // the object returned by the Content property.
            Content = new VolumeControlToolWindowControl();
        }

        public VolumeControlToolWindow(string Title) {
            Caption = Title;
            Content = new VolumeControlToolWindowControl();
        }
    }
}
