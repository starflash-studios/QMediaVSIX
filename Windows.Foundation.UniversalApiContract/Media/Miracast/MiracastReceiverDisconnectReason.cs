// Decompiled with JetBrains decompiler
// Type: Windows.Media.Miracast.MiracastReceiverDisconnectReason
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Miracast
{
  /// <summary>Specifies the reason why the app decided to disconnect the Miracast connection.</summary>
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  public enum MiracastReceiverDisconnectReason
  {
    /// <summary>The stream ended without error.</summary>
    Finished,
    /// <summary>An error occurred in the app.</summary>
    AppSpecificError,
    /// <summary>The user refused the Miracast connection.</summary>
    ConnectionNotAccepted,
    /// <summary>The user requested to stop streaming.</summary>
    DisconnectedByUser,
    /// <summary>The app was unable to start streaming, for example, a connection error.</summary>
    FailedToStartStreaming,
    /// <summary>Streaming failed due to an error in decoding the audio or video data.</summary>
    MediaDecodingError,
    /// <summary>The app encountered an error while streaming was in progress. The error was not related to decoding or decrypting of the data.</summary>
    MediaStreamingError,
    /// <summary>Streaming failed due to an error related to decrypting of the audio or video data.</summary>
    MediaDecryptionError,
  }
}
