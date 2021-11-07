// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Chat.ChatMessageAttachment
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.ApplicationModel.Chat
{
  /// <summary>Represents an attachment to a chat message.</summary>
  [Activatable(typeof (IChatMessageAttachmentFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  public sealed class ChatMessageAttachment : IChatMessageAttachment, IChatMessageAttachment2
  {
    /// <summary>Initializes a new instance of the ChatMessageAttachment class.</summary>
    /// <param name="mimeType">The MIME type of the attachment.</param>
    /// <param name="dataStreamReference">A stream containing the attachment data.</param>
    [MethodImpl]
    public extern ChatMessageAttachment(
      string mimeType,
      IRandomAccessStreamReference dataStreamReference);

    /// <summary>Gets or sets a stream reference for a message attachment.</summary>
    /// <returns>The data stream for the attachment.</returns>
    public extern IRandomAccessStreamReference DataStreamReference { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the identifier for the attachment group to which this attachment belongs.</summary>
    /// <returns>The group ID of the attachment.</returns>
    public extern uint GroupId { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the MIME type of the attachment.</summary>
    /// <returns>The MIME type of the attachment.</returns>
    public extern string MimeType { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the text encoded representation of the attachment object.</summary>
    /// <returns>The text of the attachment.</returns>
    public extern string Text { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the thumbnail image for the attachment.</summary>
    /// <returns>The thumbnail image for the attachment.</returns>
    public extern IRandomAccessStreamReference Thumbnail { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the progress of transferring the attachment.</summary>
    /// <returns>The progress of transferring the attachment.</returns>
    public extern double TransferProgress { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the original file name of the attachment.</summary>
    /// <returns>The original file name of the attachment.</returns>
    public extern string OriginalFileName { [MethodImpl] get; [MethodImpl] set; }
  }
}
