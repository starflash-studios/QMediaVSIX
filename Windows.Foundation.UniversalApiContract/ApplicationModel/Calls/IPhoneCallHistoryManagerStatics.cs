// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Calls.IPhoneCallHistoryManagerStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Calls
{
  [ExclusiveTo(typeof (PhoneCallHistoryManager))]
  [Guid(4121352761, 45855, 20293, 172, 142, 27, 8, 137, 60, 27, 80)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IPhoneCallHistoryManagerStatics
  {
    [RemoteAsync]
    IAsyncOperation<PhoneCallHistoryStore> RequestStoreAsync(
      PhoneCallHistoryStoreAccessType accessType);
  }
}
