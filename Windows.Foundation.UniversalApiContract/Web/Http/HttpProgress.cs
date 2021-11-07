// Decompiled with JetBrains decompiler
// Type: Windows.Web.Http.HttpProgress
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Web.Http
{
  /// <summary>Contains status information on the progress of an HttpClient operation.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public struct HttpProgress
  {
    /// <summary>The step in the progress of an HTTP connection.</summary>
    public HttpProgressStage Stage;
    /// <summary>The total number of bytes sent.</summary>
    public ulong BytesSent;
    /// <summary>The total number of data bytes to send.</summary>
    public IReference<ulong> TotalBytesToSend;
    /// <summary>The total number of bytes received.</summary>
    public ulong BytesReceived;
    /// <summary>The total number of data bytes to receive.</summary>
    public IReference<ulong> TotalBytesToReceive;
    /// <summary>The number of retries.</summary>
    public uint Retries;
  }
}
