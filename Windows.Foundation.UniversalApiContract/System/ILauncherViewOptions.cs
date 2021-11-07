// Decompiled with JetBrains decompiler
// Type: Windows.System.ILauncherViewOptions
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.ViewManagement;

namespace Windows.System
{
  /// <summary>Contains methods for launcher view options.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2325424625, 31911, 18910, 155, 211, 60, 91, 113, 132, 246, 22)]
  public interface ILauncherViewOptions
  {
    /// <summary>Gets the desired remaining view.</summary>
    /// <returns>The desired remaining view.</returns>
    ViewSizePreference DesiredRemainingView { get; set; }
  }
}
