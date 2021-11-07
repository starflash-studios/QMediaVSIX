// Decompiled with JetBrains decompiler
// Type: Windows.UI.ViewManagement.IUISettings5
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.ViewManagement
{
  [ExclusiveTo(typeof (UISettings))]
  [Guid(1397347720, 3253, 24325, 189, 52, 112, 107, 50, 49, 240, 189)]
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  internal interface IUISettings5
  {
    bool AutoHideScrollBars { get; }

    event TypedEventHandler<UISettings, UISettingsAutoHideScrollBarsChangedEventArgs> AutoHideScrollBarsChanged;
  }
}
