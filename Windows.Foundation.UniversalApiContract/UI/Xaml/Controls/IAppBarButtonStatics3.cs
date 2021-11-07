// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IAppBarButtonStatics3
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ExclusiveTo(typeof (AppBarButton))]
  [Guid(1299968788, 11998, 17192, 137, 6, 117, 42, 31, 39, 205, 250)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface IAppBarButtonStatics3
  {
    DependencyProperty LabelPositionProperty { get; }

    DependencyProperty IsInOverflowProperty { get; }

    DependencyProperty DynamicOverflowOrderProperty { get; }
  }
}
