// Decompiled with JetBrains decompiler
// Type: Windows.Networking.BackgroundTransfer.UnconstrainedTransferRequestResult
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.BackgroundTransfer
{
  /// <summary>Represents the result a request for unconstrained transfers from a BackgroundDownloader or BackgroundUploader object.</summary>
  /// <deprecated type="deprecate">UnconstrainedTransferRequestResult is deprecated and may not work on all platforms. For more info, see MSDN.</deprecated>
  [Threading(ThreadingModel.Both)]
  [Deprecated("UnconstrainedTransferRequestResult is deprecated and may not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class UnconstrainedTransferRequestResult : IUnconstrainedTransferRequestResult
  {
    /// <summary>Gets a value that indicates if the download or upload operations will run without the resource restrictions normally associated with background network operations while a device running on battery.</summary>
    /// <returns>**true** if the operation runs unconstrained; otherwise, **false**.</returns>
    public extern bool IsUnconstrained { [Deprecated("IsUnconstrained is deprecated and may not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }
  }
}
