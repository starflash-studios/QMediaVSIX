// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sms.ISmsMessageRegistrationStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sms
{
  [Guid(1671451748, 10392, 18296, 160, 60, 111, 153, 73, 7, 214, 58)]
  [ExclusiveTo(typeof (SmsMessageRegistration))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ISmsMessageRegistrationStatics
  {
    IVectorView<SmsMessageRegistration> AllRegistrations { get; }

    SmsMessageRegistration Register(string id, SmsFilterRules filterRules);
  }
}
