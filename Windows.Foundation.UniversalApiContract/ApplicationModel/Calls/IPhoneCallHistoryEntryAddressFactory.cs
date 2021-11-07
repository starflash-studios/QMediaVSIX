// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Calls.IPhoneCallHistoryEntryAddressFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Calls
{
  [ExclusiveTo(typeof (PhoneCallHistoryEntryAddress))]
  [Guid(4212108730, 51184, 19382, 159, 107, 186, 93, 115, 32, 154, 202)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IPhoneCallHistoryEntryAddressFactory
  {
    PhoneCallHistoryEntryAddress Create(
      string rawAddress,
      PhoneCallHistoryEntryRawAddressKind rawAddressKind);
  }
}
