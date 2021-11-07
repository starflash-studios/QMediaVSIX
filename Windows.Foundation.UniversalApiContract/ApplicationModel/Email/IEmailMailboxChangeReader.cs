// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Email.IEmailMailboxChangeReader
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Email
{
  [ExclusiveTo(typeof (EmailMailboxChangeReader))]
  [Guid(3183283899, 50493, 17201, 151, 190, 190, 117, 162, 20, 106, 117)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IEmailMailboxChangeReader
  {
    void AcceptChanges();

    void AcceptChangesThrough(EmailMailboxChange lastChangeToAcknowledge);

    [RemoteAsync]
    IAsyncOperation<IVectorView<EmailMailboxChange>> ReadBatchAsync();
  }
}
