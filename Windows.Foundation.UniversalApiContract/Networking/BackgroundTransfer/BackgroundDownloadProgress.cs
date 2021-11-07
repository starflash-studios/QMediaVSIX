// Decompiled with JetBrains decompiler
// Type: Windows.Networking.BackgroundTransfer.BackgroundDownloadProgress
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.BackgroundTransfer
{
  /// <summary>Contains status information about the download operation.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public struct BackgroundDownloadProgress
  {
    /// <summary>The total number of bytes received. This value does not include bytes received as response headers. If the download operation has restarted, this value may be smaller than in the previous progress report.</summary>
    public ulong BytesReceived;
    /// <summary>The total number of bytes of data to download. If this number is unknown, this value is set to 0.</summary>
    public ulong TotalBytesToReceive;
    /// <summary>A BackgroundTransferStatus containing the current status of the download operation.</summary>
    public BackgroundTransferStatus Status;
    /// <summary>**true** if the download request response has changed; otherwise, **false**.</summary>
    public bool HasResponseChanged;
    /// <summary>**true** if a data transfer operation has restarted; otherwise **false**.</summary>
    public bool HasRestarted;
  }
}
