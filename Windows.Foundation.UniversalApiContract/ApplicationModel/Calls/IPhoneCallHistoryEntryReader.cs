// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Calls.IPhoneCallHistoryEntryReader
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Calls
{
  [ExclusiveTo(typeof (PhoneCallHistoryEntryReader))]
  [Guid(1642915006, 36230, 18335, 132, 4, 169, 132, 105, 32, 254, 230)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IPhoneCallHistoryEntryReader
  {
    [RemoteAsync]
    IAsyncOperation<IVectorView<PhoneCallHistoryEntry>> ReadBatchAsync();
  }
}
