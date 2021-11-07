// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.IKeyboardDeliveryInterceptor
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Core;

namespace Windows.UI.Input
{
  [ExclusiveTo(typeof (KeyboardDeliveryInterceptor))]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [Guid(3032150120, 36681, 17516, 141, 181, 140, 15, 254, 133, 204, 158)]
  internal interface IKeyboardDeliveryInterceptor
  {
    bool IsInterceptionEnabledWhenInForeground { get; set; }

    event TypedEventHandler<KeyboardDeliveryInterceptor, KeyEventArgs> KeyDown;

    event TypedEventHandler<KeyboardDeliveryInterceptor, KeyEventArgs> KeyUp;
  }
}
