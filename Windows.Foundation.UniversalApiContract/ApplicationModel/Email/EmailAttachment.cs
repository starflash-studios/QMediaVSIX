// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Email.EmailAttachment
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.ApplicationModel.Email
{
  /// <summary>Represents an email attachment.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [Activatable(typeof (IEmailAttachmentFactory2), 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [Activatable(typeof (IEmailAttachmentFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class EmailAttachment : IEmailAttachment, IEmailAttachment2
  {
    /// <summary>Initializes a new instance of the EmailAttachment class.</summary>
    /// <param name="fileName">The filename of the attachment.</param>
    /// <param name="data">The stream to use to download the attachment.</param>
    /// <param name="mimeType">The MIME type of the attachment.</param>
    [MethodImpl]
    public extern EmailAttachment(
      string fileName,
      IRandomAccessStreamReference data,
      string mimeType);

    /// <summary>Initializes a new instance of the EmailAttachment class with the specified random access stream.</summary>
    /// <param name="fileName">The file name to use for the attachment.</param>
    /// <param name="data">A random access stream containing the data for the attachment.</param>
    [MethodImpl]
    public extern EmailAttachment(string fileName, IRandomAccessStreamReference data);

    /// <summary>Initializes a new instance of the EmailAttachment class.</summary>
    [MethodImpl]
    public extern EmailAttachment();

    /// <summary>Gets or sets the displayed file name for the email attachment.</summary>
    /// <returns>The displayed file name for the email attachment.</returns>
    public extern string FileName { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the email attachment's data.</summary>
    /// <returns>The email attachment data.</returns>
    public extern IRandomAccessStreamReference Data { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets the locally unique ID for the email attachment.</summary>
    /// <returns>The locally unique ID for the email attachment.</returns>
    public extern string Id { [MethodImpl] get; }

    /// <summary>Gets or sets a value that identifies the content of the attachment on a remote system.</summary>
    /// <returns>A value that identifies the content of the attachment.</returns>
    public extern string ContentId { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the location of an email attachment as a Uniform Resource Identifier (URI).</summary>
    /// <returns>The location of an email attachment as a Uniform Resource Identifier (URI).</returns>
    public extern string ContentLocation { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the download state of the email attachment.</summary>
    /// <returns>The download state of the email attachment.</returns>
    public extern EmailAttachmentDownloadState DownloadState { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the estimated download size of the attachment.</summary>
    /// <returns>The estimated download size of the attachment.</returns>
    public extern ulong EstimatedDownloadSizeInBytes { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets a Boolean value indicating if the attachment came from the base message.</summary>
    /// <returns>A Boolean value indicating if the attachment came from the base message.</returns>
    public extern bool IsFromBaseMessage { [MethodImpl] get; }

    /// <summary>Gets or sets a Boolean property indicating if the attachment is included inline, in the body of the message.</summary>
    /// <returns>A Boolean property indicating if the attachment is included inline.</returns>
    public extern bool IsInline { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the MIME type of the attachment.</summary>
    /// <returns>The MIME type of the attachment.</returns>
    public extern string MimeType { [MethodImpl] get; [MethodImpl] set; }
  }
}
