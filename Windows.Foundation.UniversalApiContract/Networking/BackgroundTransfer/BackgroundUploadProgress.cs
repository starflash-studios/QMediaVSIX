// Decompiled with JetBrains decompiler
// Type: Windows.Networking.BackgroundTransfer.BackgroundUploadProgress
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.BackgroundTransfer
{
  /// <summary>Contains status information about the upload operation.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public struct BackgroundUploadProgress
  {
    /// <summary>The total number of bytes received. This value does not include bytes received as part of response headers. If the upload operation has restarted, this value may be smaller than in the previous progress report.</summary>
    public ulong BytesReceived;
    /// <summary>The total number of bytes sent. If the upload operation has restarted, this value may be smaller than in the previous progress report.</summary>
    public ulong BytesSent;
    /// <summary>The total number of bytes of data to upload. If this number is unknown, this value is set to 0.</summary>
    public ulong TotalBytesToReceive;
    /// <summary>The total number of bytes to upload.</summary>
    public ulong TotalBytesToSend;
    /// <summary>The current status of the upload operation.</summary>
    public BackgroundTransferStatus Status;
    /// <summary>TRUE if the upload request response has changed; otherwise, FALSE.</summary>
    public bool HasResponseChanged;
    /// <summary>**true** if a upload transfer operation has restarted; otherwise **false**.</summary>
    public bool HasRestarted;
  }
}
