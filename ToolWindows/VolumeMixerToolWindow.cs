﻿using System;
using System.Runtime.InteropServices;

using Microsoft.VisualStudio.Shell;

namespace QMediaVSIX.ToolWindows {
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
  [Guid("ed2a8b26-604a-47cd-b2f4-a5aebe54583d")]
  public sealed class VolumeMixerToolWindow : ToolWindowPane {
    /// <summary>
    /// Initialises a new instance of the <see cref="VolumeMixerToolWindow"/> class.
    /// </summary>
    public VolumeMixerToolWindow() : base(null) {
      Caption = "VolumeMixerToolWindow";

      // This is the user control hosted by the tool window; Note that, even if this class implements IDisposable,
      // we are not calling Dispose on this object. This is because ToolWindowPane calls Dispose on
      // the object returned by the Content property.
      Content = new VolumeMixerToolWindowControl();
    }
  }
}
