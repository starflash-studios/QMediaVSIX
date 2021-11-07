// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Email.EmailMailboxChangeTracker
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Email
{
  /// <summary>The functionality described in this topic is not available to all UWP apps. As part of the store app submission process, Microsoft must approve your use of these APIs and provision your developer account before you can publish an app that uses them.</summary>
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class EmailMailboxChangeTracker : IEmailMailboxChangeTracker
  {
    /// <summary>Gets a Boolean value indicating whether change tracking is active.</summary>
    /// <returns>The Boolean value indicating whether change tracking is active.</returns>
    public extern bool IsTracking { [MethodImpl] get; }

    /// <summary>Enables change tracking on a mailbox.</summary>
    [MethodImpl]
    public extern void Enable();

    /// <summary>Gets a reader that will read a batch of changes.</summary>
    /// <returns>A reader that will read a batch of changes.</returns>
    [MethodImpl]
    public extern EmailMailboxChangeReader GetChangeReader();

    /// <summary>Moves the change tracking cursor to now.</summary>
    [MethodImpl]
    public extern void Reset();
  }
}
