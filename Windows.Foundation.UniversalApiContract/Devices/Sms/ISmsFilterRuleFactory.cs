// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sms.ISmsFilterRuleFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sms
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(12805384, 25238, 20265, 154, 173, 137, 32, 206, 186, 60, 232)]
  [ExclusiveTo(typeof (SmsFilterRule))]
  internal interface ISmsFilterRuleFactory
  {
    SmsFilterRule CreateFilterRule(SmsMessageType messageType);
  }
}
