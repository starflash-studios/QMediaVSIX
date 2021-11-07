// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Email.EmailMessageBatch
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Email
{
  /// <summary>Represents a collection of email messages.</summary>
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class EmailMessageBatch : IEmailMessageBatch
  {
    /// <summary>Gets a batch of email messages.</summary>
    /// <returns>A batch of email messages.</returns>
    public extern IVectorView<EmailMessage> Messages { [MethodImpl] get; }

    /// <summary>Gets the status of the email batch read.</summary>
    /// <returns>The status of the email batch read.</returns>
    public extern EmailBatchStatus Status { [MethodImpl] get; }
  }
}
