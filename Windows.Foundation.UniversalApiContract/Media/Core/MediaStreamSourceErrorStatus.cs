// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.MediaStreamSourceErrorStatus
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Core
{
  /// <summary>Specifies errors related to MediaStreamSource.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum MediaStreamSourceErrorStatus
  {
    /// <summary>An unspecified error has occurred in the application.</summary>
    Other,
    /// <summary>The application ran out of memory.</summary>
    OutOfMemory,
    /// <summary>The application failed to open a file</summary>
    FailedToOpenFile,
    /// <summary>The application failed to connect to a streaming media server or web server.</summary>
    FailedToConnectToServer,
    /// <summary>The network connection to the server was lost.</summary>
    ConnectionToServerLost,
    /// <summary>An unspecified network related error has occurred.</summary>
    UnspecifiedNetworkError,
    /// <summary>The application encountered an error while attempting to decode the media data.</summary>
    DecodeError,
    /// <summary>The application does not support the media storage format or media encoding format.</summary>
    UnsupportedMediaFormat,
  }
}
