// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Email.IEmailManagerStatics2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Email
{
  [Guid(2886020515, 45460, 16989, 182, 217, 208, 240, 65, 53, 237, 162)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (EmailManager))]
  internal interface IEmailManagerStatics2
  {
    [RemoteAsync]
    IAsyncOperation<EmailStore> RequestStoreAsync(
      EmailStoreAccessType accessType);
  }
}
