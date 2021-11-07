// Decompiled with JetBrains decompiler
// Type: Windows.UI.ViewManagement.ApplicationViewMode
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.ViewManagement
{
  /// <summary>Defines constants that specify the view mode of an app window.</summary>
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  public enum ApplicationViewMode
  {
    /// <summary>The app window is in it's default mode.</summary>
    Default,
    /// <summary>The app window is in a compact overlay (picture-in-picture) mode.</summary>
    CompactOverlay,
  }
}
