// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ISettingsFlyoutStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (SettingsFlyout))]
  [Guid(3504583989, 37207, 19428, 164, 42, 245, 145, 105, 136, 70, 172)]
  internal interface ISettingsFlyoutStatics
  {
    DependencyProperty TitleProperty { get; }

    DependencyProperty HeaderBackgroundProperty { get; }

    DependencyProperty HeaderForegroundProperty { get; }

    DependencyProperty IconSourceProperty { get; }
  }
}
