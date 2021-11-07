// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Chat.ChatMessageTransportConfiguration
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Media.MediaProperties;

namespace Windows.ApplicationModel.Chat
{
  /// <summary>Represents data about the chat message transport.</summary>
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class ChatMessageTransportConfiguration : IChatMessageTransportConfiguration
  {
    /// <summary>Gets the maximum attachment limit for a message on the transport.</summary>
    /// <returns>The maximum attachment limit for a message.</returns>
    public extern int MaxAttachmentCount { [MethodImpl] get; }

    /// <summary>Gets the maximum size of an attachment for the transport.</summary>
    /// <returns>The maximum size of an attachment.</returns>
    public extern int MaxMessageSizeInKilobytes { [MethodImpl] get; }

    /// <summary>Gets the maximum number of recipients for the transport.</summary>
    /// <returns>The maximum number of recipients.</returns>
    public extern int MaxRecipientCount { [MethodImpl] get; }

    /// <summary>Gets the supported video encoding format for the transport.</summary>
    /// <returns>The supported video encoding format for the transport.</returns>
    public extern MediaEncodingProfile SupportedVideoFormat { [MethodImpl] get; }

    /// <summary>Gets the extended properties of the transport.</summary>
    /// <returns>The extended properties of the transport.</returns>
    public extern IMapView<string, object> ExtendedProperties { [MethodImpl] get; }
  }
}
