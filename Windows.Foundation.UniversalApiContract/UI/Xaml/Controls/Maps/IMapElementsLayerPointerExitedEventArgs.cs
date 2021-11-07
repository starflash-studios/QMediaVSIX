// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Maps.IMapElementsLayerPointerExitedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Devices.Geolocation;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Maps
{
  [WebHostHidden]
  [ExclusiveTo(typeof (MapElementsLayerPointerExitedEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [Guid(2465449645, 1005, 19513, 175, 32, 42, 7, 238, 28, 206, 166)]
  internal interface IMapElementsLayerPointerExitedEventArgs
  {
    Point Position { get; }

    Geopoint Location { get; }

    MapElement MapElement { get; }
  }
}
