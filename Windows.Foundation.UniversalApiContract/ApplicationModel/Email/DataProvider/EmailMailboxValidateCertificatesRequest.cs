// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Email.DataProvider.EmailMailboxValidateCertificatesRequest
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Security.Cryptography.Certificates;

namespace Windows.ApplicationModel.Email.DataProvider
{
  /// <summary>Details of a request to validate certificates.</summary>
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  public sealed class EmailMailboxValidateCertificatesRequest : 
    IEmailMailboxValidateCertificatesRequest
  {
    /// <summary>Gets the mailbox ID against which the certificates are to be validated.</summary>
    /// <returns>A mailbox ID.</returns>
    public extern string EmailMailboxId { [MethodImpl] get; }

    /// <summary>Gets the list of certificates to be validated.</summary>
    /// <returns>A list of certificates to be validated.</returns>
    public extern IVectorView<Certificate> Certificates { [MethodImpl] get; }

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction ReportCompletedAsync(
      IIterable<EmailCertificateValidationStatus> validationStatuses);

    /// <summary>Informs the client that the request was not processed successfully. Specifically, not all of the certificates' validation state was assessed successfully.</summary>
    /// <returns>An asynchronous validation operation on an EmailMailboxValidateCertificatesRequest.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction ReportFailedAsync();
  }
}
