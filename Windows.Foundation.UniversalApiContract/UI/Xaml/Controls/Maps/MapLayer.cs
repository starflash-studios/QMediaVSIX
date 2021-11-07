// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Maps.MapLayer
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Maps
{
  /// <summary>Represents a collection of map data to which you can bind data and manipulate independently of other map types of map data.</summary>
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [Static(typeof (IMapLayerStatics), 327680, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  [Composable(typeof (IMapLayerFactory), CompositionType.Public, 327680, "Windows.Foundation.UniversalApiContract")]
  public class MapLayer : DependencyObject, IMapLayer
  {
    /// <summary>Creates a MapLayer instance.</summary>
    [MethodImpl]
    public extern MapLayer();

    /// <summary>Gets or sets a value that determines the order in which objects of the MapLayer receive focus when the user navigates through those elements by pressing the Tab key.</summary>
    /// <returns>A value that determines the order of logical navigation across elements in a MapLayer.</returns>
    public extern int MapTabIndex { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates whether the MapLayer is visible on the MapControl.</summary>
    /// <returns>**true** if the MapLayer is visible on the MapControl; otherwise, **false**.</returns>
    public extern bool Visible { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the z-index of the MapLayer. A MapLayer with a higher z-index is displayed on top of a MapLayer with a lower z-index.</summary>
    /// <returns>The z-index of the MapLayer.</returns>
    public extern int ZIndex { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Identifies the MapTagIndex dependency property.</summary>
    /// <returns>The MapTagIndex dependency property.</returns>
    public static extern DependencyProperty MapTabIndexProperty { [MethodImpl] get; }

    /// <summary>Identifies the Visible dependency property.</summary>
    /// <returns>The Visible dependency property.</returns>
    public static extern DependencyProperty VisibleProperty { [MethodImpl] get; }

    /// <summary>Identifies the ZIndex dependency property.</summary>
    /// <returns>The ZIndex dependency property.</returns>
    public static extern DependencyProperty ZIndexProperty { [MethodImpl] get; }
  }
}
