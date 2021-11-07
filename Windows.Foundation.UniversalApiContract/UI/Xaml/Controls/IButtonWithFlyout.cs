// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IButtonWithFlyout
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls.Primitives;

namespace Windows.UI.Xaml.Controls
{
  [ExclusiveTo(typeof (Button))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(152080263, 57196, 16768, 155, 58, 230, 8, 69, 130, 88, 17)]
  [WebHostHidden]
  internal interface IButtonWithFlyout
  {
    FlyoutBase Flyout { get; set; }
  }
}
