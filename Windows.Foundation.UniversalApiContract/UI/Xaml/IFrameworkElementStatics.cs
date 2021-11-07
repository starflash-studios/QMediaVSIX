// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.IFrameworkElementStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml
{
  [WebHostHidden]
  [ExclusiveTo(typeof (FrameworkElement))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1211641906, 64491, 20362, 174, 210, 238, 33, 251, 39, 165, 123)]
  internal interface IFrameworkElementStatics
  {
    DependencyProperty TagProperty { get; }

    DependencyProperty LanguageProperty { get; }

    DependencyProperty ActualWidthProperty { get; }

    DependencyProperty ActualHeightProperty { get; }

    DependencyProperty WidthProperty { get; }

    DependencyProperty HeightProperty { get; }

    DependencyProperty MinWidthProperty { get; }

    DependencyProperty MaxWidthProperty { get; }

    DependencyProperty MinHeightProperty { get; }

    DependencyProperty MaxHeightProperty { get; }

    DependencyProperty HorizontalAlignmentProperty { get; }

    DependencyProperty VerticalAlignmentProperty { get; }

    DependencyProperty MarginProperty { get; }

    DependencyProperty NameProperty { get; }

    DependencyProperty DataContextProperty { get; }

    DependencyProperty StyleProperty { get; }

    DependencyProperty FlowDirectionProperty { get; }
  }
}
