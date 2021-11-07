// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IMenuFlyoutItemStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1230025764, 42042, 16887, 170, 58, 156, 233, 97, 151, 71, 213)]
  [ExclusiveTo(typeof (MenuFlyoutItem))]
  [WebHostHidden]
  internal interface IMenuFlyoutItemStatics
  {
    DependencyProperty TextProperty { get; }

    DependencyProperty CommandProperty { get; }

    DependencyProperty CommandParameterProperty { get; }
  }
}
