// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Maps.MapElement
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Maps
{
  /// <summary>Represents an element displayed on a MapControl.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [Static(typeof (IMapElementStatics3), 327680, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IMapElementStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Composable(typeof (IMapElementFactory), CompositionType.Public, 65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IMapElementStatics4), 393216, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IMapElementStatics2), 65536, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  public class MapElement : DependencyObject, IMapElement, IMapElement2, IMapElement3, IMapElement4
  {
    /// <summary>Initializes a new instance of the MapElement class.</summary>
    [MethodImpl]
    public extern MapElement();

    /// <summary>Gets or sets the z-index of the MapElement. A MapElement with a higher z-index is displayed on top of a MapElement with a lower z-index.</summary>
    /// <returns>The z-index of the MapElement.</returns>
    public extern int ZIndex { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates whether the MapElement is visible on the MapControl.</summary>
    /// <returns>**true** if the MapElement is visible on the MapControl; otherwise, **false**.</returns>
    public extern bool Visible { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that determines the order in which elements of the MapControl receive focus when the user navigates through those elements by pressing the Tab key.</summary>
    /// <returns>A value that determines the order of logical navigation across elements in a MapControl.</returns>
    public extern int MapTabIndex { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the name of an entry in the map's style sheet that you'd like to apply to this MapElement.</summary>
    /// <returns>The name of the entry in the map's style sheet that you'd like to apply to this MapElement. This name may be an existing map element (see remarks) that acts like an existing base map element of that type. Or the name may be an extension that is not used by the base map but is set by the style sheet creator and can be changed without affecting the base map (see the example code).</returns>
    public extern string MapStyleSheetEntry { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the name of the state of this MapElement. If the style sheet defines a style for that state, that style is applied to this element. Values defined in the style sheet for the state override values defined in the MapStyleSheetEntry.</summary>
    /// <returns>The name of the state of this MapElement.</returns>
    public extern string MapStyleSheetEntryState { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets an arbitrary object value that can be used to store custom information about this object.</summary>
    /// <returns>An arbitrary object value that can be used to store custom information about this object.</returns>
    public extern object Tag { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Indicates whether users can interact with the MapElement.</summary>
    /// <returns>**true** if users can interact with the MapElement; otherwise, **false**.</returns>
    public extern bool IsEnabled { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Identifies the IsEnabled dependency property.</summary>
    /// <returns>Identifier for the IsEnabled dependency property.</returns>
    public static extern DependencyProperty IsEnabledProperty { [MethodImpl] get; }

    /// <summary>Identifies for the MapStyleSheetEntry dependency property.</summary>
    /// <returns>Identifier for the MapStyleSheetEntry dependency property.</returns>
    public static extern DependencyProperty MapStyleSheetEntryProperty { [MethodImpl] get; }

    /// <summary>Identifies for the MapStyleSheetEntryState dependency property.</summary>
    /// <returns>Identifier for the MapStyleSheetEntryState dependency property.</returns>
    public static extern DependencyProperty MapStyleSheetEntryStateProperty { [MethodImpl] get; }

    /// <summary>Identifies the Tag dependency property.</summary>
    /// <returns>The Tag dependency property.</returns>
    public static extern DependencyProperty TagProperty { [MethodImpl] get; }

    /// <summary>Identifies the MapTabIndex dependency property.</summary>
    /// <returns>The identifier for the MapTabIndex dependency property.</returns>
    public static extern DependencyProperty MapTabIndexProperty { [MethodImpl] get; }

    /// <summary>Identifies the ZIndex dependency property.</summary>
    /// <returns>The identifier for the ZIndex dependency property.</returns>
    public static extern DependencyProperty ZIndexProperty { [MethodImpl] get; }

    /// <summary>Identifies the Visible dependency property.</summary>
    /// <returns>The identifier for the Visible dependency property.</returns>
    public static extern DependencyProperty VisibleProperty { [MethodImpl] get; }
  }
}
