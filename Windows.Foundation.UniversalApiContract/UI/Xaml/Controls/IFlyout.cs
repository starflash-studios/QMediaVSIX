// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IFlyout
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [Guid(1703209951, 52167, 19993, 132, 58, 161, 79, 36, 167, 147, 234)]
  [ExclusiveTo(typeof (Flyout))]
  internal interface IFlyout
  {
    UIElement Content { get; set; }

    Style FlyoutPresenterStyle { get; set; }
  }
}
