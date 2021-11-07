// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IMenuFlyoutItem2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [Guid(182609643, 652, 17443, 168, 227, 152, 159, 217, 221, 113, 38)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [WebHostHidden]
  [ExclusiveTo(typeof (MenuFlyoutItem))]
  internal interface IMenuFlyoutItem2
  {
    IconElement Icon { get; set; }
  }
}
