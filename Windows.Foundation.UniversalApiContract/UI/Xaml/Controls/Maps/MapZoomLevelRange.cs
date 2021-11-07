// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Maps.MapZoomLevelRange
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Maps
{
  /// <summary>Specifies the minimum and maximum zoom level for a MapTileSource. This structure is used by the ZoomLevelRange property of a MapTileSource.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  public struct MapZoomLevelRange
  {
    /// <summary>The minimum zoom level for a MapTileSource.</summary>
    public double Min;
    /// <summary>The maximum zoom level for a MapTileSource.</summary>
    public double Max;
  }
}
