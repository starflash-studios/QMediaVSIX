// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Chat.RcsTransportConfiguration
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Chat
{
  /// <summary>Provides data about the configuration of a Rich Communication Services (RCS) transport.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class RcsTransportConfiguration : IRcsTransportConfiguration
  {
    /// <summary>Gets the maximum number of attachments supported by the transport.</summary>
    /// <returns>The maximum number of attachments supported by the transport.</returns>
    public extern int MaxAttachmentCount { [MethodImpl] get; }

    /// <summary>Gets the maximum size of a chat message supported by the transport.</summary>
    /// <returns>The maximum size of a chat message supported by the transport.</returns>
    public extern int MaxMessageSizeInKilobytes { [MethodImpl] get; }

    /// <summary>Gets the maximum size of a group chat message supported by the transport.</summary>
    /// <returns>The maximum size of a group chat message supported by the transport.</returns>
    public extern int MaxGroupMessageSizeInKilobytes { [MethodImpl] get; }

    /// <summary>Gets the maximum number of recipients supported for a group chat.</summary>
    /// <returns>The maximum number of recipients supported for a group chat.</returns>
    public extern int MaxRecipientCount { [MethodImpl] get; }

    /// <summary>Gets the maximum size of a file that can be sent using the transport.</summary>
    /// <returns>The maximum size of a file that can be sent using the transport.</returns>
    public extern int MaxFileSizeInKilobytes { [MethodImpl] get; }

    /// <summary>Gets the size at which the user should be warned that they are attaching a large file for the transport.</summary>
    /// <returns>The size at which the user should be warned that they are attaching a large file for the transport.</returns>
    public extern int WarningFileSizeInKilobytes { [MethodImpl] get; }
  }
}
