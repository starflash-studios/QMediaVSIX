// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Maps.IMapStyleSheetStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Maps
{
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [ExclusiveTo(typeof (MapStyleSheet))]
  [Guid(2881290413, 2588, 17205, 130, 244, 97, 217, 54, 170, 25, 125)]
  internal interface IMapStyleSheetStatics
  {
    MapStyleSheet Aerial();

    MapStyleSheet AerialWithOverlay();

    MapStyleSheet RoadLight();

    MapStyleSheet RoadDark();

    MapStyleSheet RoadHighContrastLight();

    MapStyleSheet RoadHighContrastDark();

    MapStyleSheet Combine(IIterable<MapStyleSheet> styleSheets);

    MapStyleSheet ParseFromJson(string styleAsJson);

    bool TryParseFromJson(string styleAsJson, out MapStyleSheet styleSheet);
  }
}
