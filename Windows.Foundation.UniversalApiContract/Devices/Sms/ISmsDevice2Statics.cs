// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sms.ISmsDevice2Statics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sms
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1707574053, 4145, 18718, 143, 182, 239, 153, 145, 175, 227, 99)]
  [ExclusiveTo(typeof (SmsDevice2))]
  internal interface ISmsDevice2Statics
  {
    string GetDeviceSelector();

    SmsDevice2 FromId(string deviceId);

    SmsDevice2 GetDefault();

    SmsDevice2 FromParentId(string parentDeviceId);
  }
}
