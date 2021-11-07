// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IToggleMenuFlyoutItem
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1233395421, 35049, 18019, 167, 1, 205, 79, 210, 94, 57, 143)]
  [ExclusiveTo(typeof (ToggleMenuFlyoutItem))]
  internal interface IToggleMenuFlyoutItem
  {
    bool IsChecked { get; set; }
  }
}
