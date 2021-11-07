// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IFlyoutStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ExclusiveTo(typeof (Flyout))]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1630948875, 56181, 18401, 178, 195, 91, 144, 28, 61, 116, 182)]
  internal interface IFlyoutStatics
  {
    DependencyProperty ContentProperty { get; }

    DependencyProperty FlyoutPresenterStyleProperty { get; }
  }
}
