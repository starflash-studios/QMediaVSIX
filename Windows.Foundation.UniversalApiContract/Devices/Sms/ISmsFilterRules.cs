// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sms.ISmsFilterRules
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sms
{
  [ExclusiveTo(typeof (SmsFilterRules))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1313336059, 31181, 18561, 152, 148, 85, 164, 19, 91, 35, 250)]
  internal interface ISmsFilterRules
  {
    SmsFilterActionType ActionType { get; }

    IVector<SmsFilterRule> Rules { get; }
  }
}
