// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Maps.IMapElementsLayerClickEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Devices.Geolocation;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Maps
{
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [ExclusiveTo(typeof (MapElementsLayerClickEventArgs))]
  [Guid(749195110, 44827, 19461, 140, 133, 247, 74, 227, 212, 103, 127)]
  [WebHostHidden]
  internal interface IMapElementsLayerClickEventArgs
  {
    Point Position { get; }

    Geopoint Location { get; }

    IVector<MapElement> MapElements { get; }
  }
}
