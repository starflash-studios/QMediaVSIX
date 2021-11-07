// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IToggleMenuFlyoutItemFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [Guid(2706478703, 15351, 18102, 182, 28, 155, 44, 27, 166, 136, 67)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (ToggleMenuFlyoutItem))]
  [WebHostHidden]
  internal interface IToggleMenuFlyoutItemFactory
  {
    ToggleMenuFlyoutItem CreateInstance(
      object baseInterface,
      out object innerInterface);
  }
}
