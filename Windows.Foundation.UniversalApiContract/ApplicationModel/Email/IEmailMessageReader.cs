// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Email.IEmailMessageReader
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Email
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(793427615, 25107, 19077, 163, 176, 249, 45, 26, 131, 157, 25)]
  [ExclusiveTo(typeof (EmailMessageReader))]
  internal interface IEmailMessageReader
  {
    [RemoteAsync]
    IAsyncOperation<EmailMessageBatch> ReadBatchAsync();
  }
}
