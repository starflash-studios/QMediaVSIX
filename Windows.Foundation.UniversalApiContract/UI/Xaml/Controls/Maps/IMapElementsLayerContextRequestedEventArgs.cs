// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Maps.IMapElementsLayerContextRequestedEventArgs
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
  [WebHostHidden]
  [Guid(3662008499, 31246, 18264, 128, 139, 58, 99, 118, 39, 235, 13)]
  [ExclusiveTo(typeof (MapElementsLayerContextRequestedEventArgs))]
  internal interface IMapElementsLayerContextRequestedEventArgs
  {
    Point Position { get; }

    Geopoint Location { get; }

    IVectorView<MapElement> MapElements { get; }
  }
}
