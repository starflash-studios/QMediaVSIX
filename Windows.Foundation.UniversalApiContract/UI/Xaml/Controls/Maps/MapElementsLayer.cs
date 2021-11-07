// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Maps.MapElementsLayer
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Maps
{
  /// <summary>Represents a collection of map elements to which you can bind data and manipulate independently of other map elements.</summary>
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [Static(typeof (IMapElementsLayerStatics), 327680, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(327680, "Windows.Foundation.UniversalApiContract")]
  public sealed class MapElementsLayer : MapLayer, IMapElementsLayer
  {
    /// <summary>Creates a MapElementsLayer instance.</summary>
    [MethodImpl]
    public extern MapElementsLayer();

    /// <summary>Gets the collection of MapElement objects that are children of the MapElementsLayer.</summary>
    /// <returns>The collection of MapElement objects that are children of the MapElementsLayer.</returns>
    public extern IVector<MapElement> MapElements { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Occurs when the user taps or clicks a MapElement that has been add to the MapElementsLayer.</summary>
    public extern event TypedEventHandler<MapElementsLayer, MapElementsLayerClickEventArgs> MapElementClick;

    /// <summary>Occurs when a pointer moves into the bounding area of a MapElement on a MapElementsLayer.</summary>
    public extern event TypedEventHandler<MapElementsLayer, MapElementsLayerPointerEnteredEventArgs> MapElementPointerEntered;

    /// <summary>Occurs when a pointer moves out of the bounding area of a MapElement on a MapElementsLayer.</summary>
    public extern event TypedEventHandler<MapElementsLayer, MapElementsLayerPointerExitedEventArgs> MapElementPointerExited;

    /// <summary>Occurs when the user has completed a context input gesture on a map layer, such as a right-click.</summary>
    public extern event TypedEventHandler<MapElementsLayer, MapElementsLayerContextRequestedEventArgs> MapContextRequested;

    /// <summary>Identifies the MapElements dependency property.</summary>
    /// <returns>The MapElements dependency property.</returns>
    public static extern DependencyProperty MapElementsProperty { [MethodImpl] get; }
  }
}
