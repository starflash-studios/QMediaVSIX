// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ISwipeItemStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [Guid(3501477526, 10086, 19859, 181, 219, 245, 225, 190, 131, 44, 45)]
  [WebHostHidden]
  [ExclusiveTo(typeof (SwipeItem))]
  internal interface ISwipeItemStatics
  {
    DependencyProperty IconSourceProperty { get; }

    DependencyProperty TextProperty { get; }

    DependencyProperty BackgroundProperty { get; }

    DependencyProperty ForegroundProperty { get; }

    DependencyProperty CommandProperty { get; }

    DependencyProperty CommandParameterProperty { get; }

    DependencyProperty BehaviorOnInvokedProperty { get; }
  }
}
