// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Email.EmailMailboxAutoReplySettings
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Email
{
  /// <summary>Represents the settings for the automatic reply functionality of an email account.</summary>
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class EmailMailboxAutoReplySettings : IEmailMailboxAutoReplySettings
  {
    /// <summary>Initializes a new instance of an  object.</summary>
    [MethodImpl]
    public extern EmailMailboxAutoReplySettings();

    /// <summary>Gets a Boolean value indicating whether automatic replies are enabled.</summary>
    /// <returns>A Boolean value indicating whether automatic replies are enabled.</returns>
    public extern bool IsEnabled { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets whether the automated response email message is encoded as HTML or plain text.</summary>
    /// <returns>The encoding schema for an email message.</returns>
    public extern EmailMailboxAutoReplyMessageResponseKind ResponseKind { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Represents the start time for the automated reply period.</summary>
    /// <returns>The start time for the automated reply period.</returns>
    public extern IReference<DateTime> StartTime { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Represents the end time for the automated reply period.</summary>
    /// <returns>The end time for the automated reply period.</returns>
    public extern IReference<DateTime> EndTime { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets the automatic reply message intended for an email message from an internal sender.</summary>
    /// <returns>The automatic reply message intended for an email message from an internal sender.</returns>
    public extern EmailMailboxAutoReply InternalReply { [MethodImpl] get; }

    /// <summary>Gets the automatic reply message intended for an email message from a known external sender.</summary>
    /// <returns>The automatic reply message intended for an email message from a known external sender.</returns>
    public extern EmailMailboxAutoReply KnownExternalReply { [MethodImpl] get; }

    /// <summary>Gets the automatic reply message intended for an email message from an unknown external sender.</summary>
    /// <returns>The automatic reply message intended for an email message from an unknown external sender.</returns>
    public extern EmailMailboxAutoReply UnknownExternalReply { [MethodImpl] get; }
  }
}
