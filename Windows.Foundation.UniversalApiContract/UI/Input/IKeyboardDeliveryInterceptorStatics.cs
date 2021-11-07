// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.IKeyboardDeliveryInterceptorStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input
{
  [ExclusiveTo(typeof (KeyboardDeliveryInterceptor))]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [Guid(4193663906, 52922, 18261, 138, 126, 20, 192, 255, 236, 210, 57)]
  internal interface IKeyboardDeliveryInterceptorStatics
  {
    KeyboardDeliveryInterceptor GetForCurrentView();
  }
}
