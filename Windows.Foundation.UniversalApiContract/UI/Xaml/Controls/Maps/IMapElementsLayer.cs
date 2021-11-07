// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Maps.IMapElementsLayer
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Maps
{
  [Guid(3732498586, 495, 18164, 172, 96, 124, 32, 11, 85, 38, 16)]
  [ExclusiveTo(typeof (MapElementsLayer))]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  internal interface IMapElementsLayer
  {
    IVector<MapElement> MapElements { get; set; }

    event TypedEventHandler<MapElementsLayer, MapElementsLayerClickEventArgs> MapElementClick;

    event TypedEventHandler<MapElementsLayer, MapElementsLayerPointerEnteredEventArgs> MapElementPointerEntered;

    event TypedEventHandler<MapElementsLayer, MapElementsLayerPointerExitedEventArgs> MapElementPointerExited;

    event TypedEventHandler<MapElementsLayer, MapElementsLayerContextRequestedEventArgs> MapContextRequested;
  }
}
