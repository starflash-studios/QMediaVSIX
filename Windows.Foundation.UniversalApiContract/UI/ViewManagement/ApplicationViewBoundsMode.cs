// Decompiled with JetBrains decompiler
// Type: Windows.UI.ViewManagement.ApplicationViewBoundsMode
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.ViewManagement
{
  /// <summary>The bounds used by the framework to lay out the contents of a window (app view).</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum ApplicationViewBoundsMode
  {
    /// <summary>Lay out the window's content within the visible region (that is, the region not occluded by chrome such as the status bar and app bar).</summary>
    UseVisible,
    /// <summary>Lay out the window's content within the region occupied by the core window (that is, including any occluded areas).</summary>
    UseCoreWindow,
  }
}
