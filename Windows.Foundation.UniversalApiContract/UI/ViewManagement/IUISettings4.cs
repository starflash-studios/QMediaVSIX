// Decompiled with JetBrains decompiler
// Type: Windows.UI.ViewManagement.IUISettings4
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.ViewManagement
{
  [ExclusiveTo(typeof (UISettings))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(1387999234, 37275, 19819, 155, 120, 141, 214, 111, 244, 185, 59)]
  internal interface IUISettings4
  {
    bool AdvancedEffectsEnabled { get; }

    event TypedEventHandler<UISettings, object> AdvancedEffectsEnabledChanged;
  }
}
