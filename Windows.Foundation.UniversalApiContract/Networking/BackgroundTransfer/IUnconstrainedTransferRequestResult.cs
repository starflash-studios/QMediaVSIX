// Decompiled with JetBrains decompiler
// Type: Windows.Networking.BackgroundTransfer.IUnconstrainedTransferRequestResult
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.BackgroundTransfer
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1277474847, 55620, 16658, 169, 142, 106, 105, 82, 43, 126, 187)]
  [ExclusiveTo(typeof (UnconstrainedTransferRequestResult))]
  [Deprecated("IUnconstrainedTransferRequestResult is deprecated and may not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract")]
  internal interface IUnconstrainedTransferRequestResult
  {
    bool IsUnconstrained { [Deprecated("IsUnconstrained is deprecated and may not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract")] get; }
  }
}
