// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Contacts.IAggregateContactManager2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Contacts
{
  [Guid(1586283224, 43469, 17456, 156, 75, 1, 52, 141, 178, 202, 80)]
  [ExclusiveTo(typeof (AggregateContactManager))]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface IAggregateContactManager2
  {
    [RemoteAsync]
    IAsyncAction SetRemoteIdentificationInformationAsync(
      string contactListId,
      string remoteSourceId,
      string accountId);
  }
}
