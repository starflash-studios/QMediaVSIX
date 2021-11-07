// Decompiled with JetBrains decompiler
// Type: Windows.UI.ViewManagement.ApplicationViewOrientation
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.ViewManagement
{
  /// <summary>Defines the set of display orientation modes for a window (app view).</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum ApplicationViewOrientation
  {
    /// <summary>The window is in landscape orientation, with the display width greater than the height.</summary>
    Landscape,
    /// <summary>The window is in portrait orientation, with the display height greater than the width.</summary>
    Portrait,
  }
}
