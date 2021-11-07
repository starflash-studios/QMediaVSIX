// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Email.EmailMailboxAction
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Email
{
  /// <summary>Provides data about a change that occurred to a mailbox.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class EmailMailboxAction : IEmailMailboxAction
  {
    /// <summary>Gets the value that represents the kind of change that happened to the mailbox.</summary>
    /// <returns>The kind of change that happened to the mailbox.</returns>
    public extern EmailMailboxActionKind Kind { [MethodImpl] get; }

    /// <summary>Gets the number that identifies the change that happened to the mailbox.</summary>
    /// <returns>The number that identifies the change that occurred to the mailbox.</returns>
    public extern ulong ChangeNumber { [MethodImpl] get; }
  }
}
