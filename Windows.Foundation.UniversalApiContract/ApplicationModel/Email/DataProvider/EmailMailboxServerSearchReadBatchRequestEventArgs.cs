// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Email.DataProvider.EmailMailboxServerSearchReadBatchRequestEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Email.DataProvider
{
  /// <summary>Encapsulates information about a request to read a batch of results from a server-side search.</summary>
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  public sealed class EmailMailboxServerSearchReadBatchRequestEventArgs : 
    IEmailMailboxServerSearchReadBatchRequestEventArgs
  {
    /// <summary>Gets the EmailMailboxServerSearchReadBatchRequest object associated with this request.</summary>
    /// <returns>An EmailMailboxServerSearchReadBatchRequest object describing the request to read a batch of server-side search results.</returns>
    public extern EmailMailboxServerSearchReadBatchRequest Request { [MethodImpl] get; }

    /// <summary>Gets a deferral object for this operation.</summary>
    /// <returns>A Deferral object that your code uses to signal when it has finished processing this request.</returns>
    [MethodImpl]
    public extern Deferral GetDeferral();
  }
}
