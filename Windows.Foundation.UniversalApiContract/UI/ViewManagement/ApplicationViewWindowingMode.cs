// Decompiled with JetBrains decompiler
// Type: Windows.UI.ViewManagement.ApplicationViewWindowingMode
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.ViewManagement
{
  /// <summary>Defines constants that specify whether the app window is auto-sized, full-screen, or set to a specific size on launch.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum ApplicationViewWindowingMode
  {
    /// <summary>The system sizes the app window automatically.</summary>
    Auto,
    /// <summary>The window is sized as specified by the ApplicationView.PreferredLaunchViewSize property.</summary>
    PreferredLaunchViewSize,
    /// <summary>The window is full-screen.</summary>
    FullScreen,
    /// <summary>The window is shown as a compact overlay (picture-in-picture).</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 458752)] CompactOverlay,
    /// <summary>The window is maximized.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 458752)] Maximized,
  }
}
