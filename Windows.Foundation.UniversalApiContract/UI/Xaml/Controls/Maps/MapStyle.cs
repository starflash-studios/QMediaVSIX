// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Maps.MapStyle
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Maps
{
  /// <summary>Specifies the Style of the MapControl.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  public enum MapStyle
  {
    /// <summary>A style is not specified.</summary>
    None,
    /// <summary>A road map.</summary>
    Road,
    /// <summary>An aerial map.</summary>
    Aerial,
    /// <summary>A hybrid map that combines an aerial map with roads.</summary>
    AerialWithRoads,
    /// <summary>A terrain map.</summary>
    Terrain,
    /// <summary>An aerial 3D map.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] Aerial3D,
    /// <summary>A hybrid map that combines an aerial 3D map with roads.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] Aerial3DWithRoads,
    /// <summary>
    /// </summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 262144)] Custom,
  }
}
