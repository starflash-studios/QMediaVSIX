// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Email.EmailMailboxChangeReader
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Email
{
  /// <summary>The functionality described in this topic is not available to all UWP apps. As part of the store app submission process, Microsoft must approve your use of these APIs and provision your developer account before you can publish an app that uses them.</summary>
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class EmailMailboxChangeReader : IEmailMailboxChangeReader
  {
    /// <summary>Accepts all changes.</summary>
    [MethodImpl]
    public extern void AcceptChanges();

    /// <summary>Accepts all changes through the current change.</summary>
    /// <param name="lastChangeToAcknowledge">The current change.</param>
    [MethodImpl]
    public extern void AcceptChangesThrough(EmailMailboxChange lastChangeToAcknowledge);

    /// <summary>Reads a collection of changes.</summary>
    /// <returns>A batch of changes.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<IVectorView<EmailMailboxChange>> ReadBatchAsync();
  }
}
