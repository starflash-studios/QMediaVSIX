// Decompiled with JetBrains decompiler
// Type: Windows.Web.Http.HttpProgressStage
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Web.Http
{
  /// <summary>Indicates the step in the progress for an HTTP connection.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum HttpProgressStage
  {
    /// <summary>A default value that should not be encountered.</summary>
    None = 0,
    /// <summary>The system starts to detect a proxy.</summary>
    DetectingProxy = 10, // 0x0000000A
    /// <summary>The system is resolving the hostname for the HTTP connection.</summary>
    ResolvingName = 20, // 0x00000014
    /// <summary>The socket used for the HTTP connection is connecting to the server.</summary>
    ConnectingToServer = 30, // 0x0000001E
    /// <summary>The HTTP connection to the server is negotiating SSL.</summary>
    NegotiatingSsl = 40, // 0x00000028
    /// <summary>HTTP headers are being sent to the server.</summary>
    SendingHeaders = 50, // 0x00000032
    /// <summary>HTTP content is being sent to the server.</summary>
    SendingContent = 60, // 0x0000003C
    /// <summary>The HTTP client is waiting for a response from the server.</summary>
    WaitingForResponse = 70, // 0x00000046
    /// <summary>The HTTP client is receiving headers from the server.</summary>
    ReceivingHeaders = 80, // 0x00000050
    /// <summary>The HTTP client is receiving content from the server.</summary>
    ReceivingContent = 90, // 0x0000005A
  }
}
