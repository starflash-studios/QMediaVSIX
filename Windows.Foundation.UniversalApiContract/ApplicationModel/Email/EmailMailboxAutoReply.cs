// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Email.EmailMailboxAutoReply
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Email
{
  /// <summary>Represents an auto-reply message set on a mailbox.</summary>
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class EmailMailboxAutoReply : IEmailMailboxAutoReply
  {
    /// <summary>Gets or sets a Boolean value that indicates if the auto-reply message is enabled.</summary>
    /// <returns>A Boolean value that indicates if the auto-reply message is enabled.</returns>
    public extern bool IsEnabled { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the auto-reply response text.</summary>
    /// <returns>The auto-reply response text.</returns>
    public extern string Response { [MethodImpl] get; [MethodImpl] set; }
  }
}
