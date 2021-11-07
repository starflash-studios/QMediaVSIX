// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Email.IEmailConversationReader
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Email
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (EmailConversationReader))]
  [Guid(3026390914, 10357, 17608, 155, 140, 133, 190, 179, 163, 198, 83)]
  internal interface IEmailConversationReader
  {
    [RemoteAsync]
    IAsyncOperation<EmailConversationBatch> ReadBatchAsync();
  }
}
