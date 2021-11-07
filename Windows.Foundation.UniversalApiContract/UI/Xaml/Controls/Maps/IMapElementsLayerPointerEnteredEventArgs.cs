// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Maps.IMapElementsLayerPointerEnteredEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Devices.Geolocation;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Maps
{
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [ExclusiveTo(typeof (MapElementsLayerPointerEnteredEventArgs))]
  [WebHostHidden]
  [Guid(1971306546, 18068, 17412, 140, 137, 52, 139, 107, 118, 197, 230)]
  internal interface IMapElementsLayerPointerEnteredEventArgs
  {
    Point Position { get; }

    Geopoint Location { get; }

    MapElement MapElement { get; }
  }
}
