// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sms.ISmsFilterRulesFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sms
{
  [Guid(2694391021, 28206, 17712, 159, 222, 70, 93, 2, 238, 208, 14)]
  [ExclusiveTo(typeof (SmsFilterRules))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ISmsFilterRulesFactory
  {
    SmsFilterRules CreateFilterRules(SmsFilterActionType actionType);
  }
}
