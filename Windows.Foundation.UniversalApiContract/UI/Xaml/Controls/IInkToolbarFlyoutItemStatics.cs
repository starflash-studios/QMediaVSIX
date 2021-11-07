// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IInkToolbarFlyoutItemStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [WebHostHidden]
  [ExclusiveTo(typeof (InkToolbarFlyoutItem))]
  [Guid(535120740, 16483, 19039, 184, 156, 159, 88, 147, 94, 227, 121)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  internal interface IInkToolbarFlyoutItemStatics
  {
    DependencyProperty KindProperty { get; }

    DependencyProperty IsCheckedProperty { get; }
  }
}
