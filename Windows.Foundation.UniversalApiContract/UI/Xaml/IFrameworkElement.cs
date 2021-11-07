// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.IFrameworkElement
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Data;

namespace Windows.UI.Xaml
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [Guid(2744242331, 19097, 19324, 157, 141, 111, 165, 208, 31, 111, 191)]
  [ExclusiveTo(typeof (FrameworkElement))]
  internal interface IFrameworkElement
  {
    TriggerCollection Triggers { get; }

    ResourceDictionary Resources { get; set; }

    object Tag { get; set; }

    string Language { get; set; }

    double ActualWidth { get; }

    double ActualHeight { get; }

    double Width { get; set; }

    double Height { get; set; }

    double MinWidth { get; set; }

    double MaxWidth { get; set; }

    double MinHeight { get; set; }

    double MaxHeight { get; set; }

    HorizontalAlignment HorizontalAlignment { get; set; }

    VerticalAlignment VerticalAlignment { get; set; }

    Thickness Margin { get; set; }

    string Name { get; set; }

    Uri BaseUri { get; }

    object DataContext { get; set; }

    Style Style { get; set; }

    DependencyObject Parent { get; }

    FlowDirection FlowDirection { get; set; }

    event RoutedEventHandler Loaded;

    event RoutedEventHandler Unloaded;

    event SizeChangedEventHandler SizeChanged;

    event EventHandler<object> LayoutUpdated;

    object FindName(string name);

    void SetBinding(DependencyProperty dp, BindingBase binding);
  }
}
