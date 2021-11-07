// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Calls.IPhoneCallHistoryManagerForUser
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.System;

namespace Windows.ApplicationModel.Calls
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(3643131171, 62815, 17235, 157, 180, 2, 5, 165, 38, 90, 85)]
  [ExclusiveTo(typeof (PhoneCallHistoryManagerForUser))]
  internal interface IPhoneCallHistoryManagerForUser
  {
    [RemoteAsync]
    IAsyncOperation<PhoneCallHistoryStore> RequestStoreAsync(
      PhoneCallHistoryStoreAccessType accessType);

    User User { get; }
  }
}
