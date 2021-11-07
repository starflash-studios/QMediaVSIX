// Decompiled with JetBrains decompiler
// Type: Windows.UI.ViewManagement.IUISettings6
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.ViewManagement
{
  [ExclusiveTo(typeof (UISettings))]
  [ContractVersion(typeof (UniversalApiContract), 655360)]
  [Guid(2935069655, 65073, 23044, 173, 164, 70, 154, 174, 198, 223, 169)]
  internal interface IUISettings6
  {
    event TypedEventHandler<UISettings, UISettingsAnimationsEnabledChangedEventArgs> AnimationsEnabledChanged;

    event TypedEventHandler<UISettings, UISettingsMessageDurationChangedEventArgs> MessageDurationChanged;
  }
}
