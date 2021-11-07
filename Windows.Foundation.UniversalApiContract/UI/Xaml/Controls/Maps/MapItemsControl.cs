// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Maps.MapItemsControl
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Markup;

namespace Windows.UI.Xaml.Controls.Maps
{
  /// <summary>Contains a collection of XAML controls to be displayed on a MapControl.</summary>
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [ContentProperty(Name = "Items")]
  [Static(typeof (IMapItemsControlStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  public sealed class MapItemsControl : DependencyObject, IMapItemsControl
  {
    /// <summary>Initializes a new instance of the MapItemsControl class.</summary>
    [MethodImpl]
    public extern MapItemsControl();

    /// <summary>Gets or sets a source that provides the content of the MapItemsControl.</summary>
    /// <returns>A source that provides the content of the MapItemsControl.</returns>
    public extern object ItemsSource { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets a collection of XAML controls to be displayed on a MapControl.</summary>
    /// <returns>A collection of XAML controls to be displayed on a MapControl.</returns>
    public extern IVector<DependencyObject> Items { [MethodImpl] get; }

    /// <summary>Gets or sets the DataTemplate used to display each item.</summary>
    /// <returns>The DataTemplate used to display each item.</returns>
    public extern DataTemplate ItemTemplate { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Identifies the ItemsSource dependency property.</summary>
    /// <returns>The identifier for the ItemsSource dependency property.</returns>
    public static extern DependencyProperty ItemsSourceProperty { [MethodImpl] get; }

    /// <summary>Identifies the Items dependency property.</summary>
    /// <returns>The identifier for the Items dependency property.</returns>
    public static extern DependencyProperty ItemsProperty { [MethodImpl] get; }

    /// <summary>Identifies the ItemTemplate dependency property.</summary>
    /// <returns>The identifier for the ItemTemplate dependency property.</returns>
    public static extern DependencyProperty ItemTemplateProperty { [MethodImpl] get; }
  }
}
