// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Maps.MapTileLayer
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Maps
{
  /// <summary>Specifies the Layer type of a MapTileSource.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  public enum MapTileLayer
  {
    /// <summary>The MapTileSource is a label overlay.</summary>
    LabelOverlay,
    /// <summary>The MapTileSource is a road overlay.</summary>
    RoadOverlay,
    /// <summary>The MapTileSource is an area overlay.</summary>
    AreaOverlay,
    /// <summary>The MapTileSource is a background overlay.</summary>
    BackgroundOverlay,
    /// <summary>The MapTileSource is a background replacement overlay.</summary>
    BackgroundReplacement,
  }
}
