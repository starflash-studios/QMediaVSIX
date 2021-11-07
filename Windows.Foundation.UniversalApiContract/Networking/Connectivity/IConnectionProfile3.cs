// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Connectivity.IConnectionProfile3
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Connectivity
{
  [Guid(1468802344, 19673, 16737, 128, 69, 32, 28, 253, 91, 17, 92)]
  [ExclusiveTo(typeof (ConnectionProfile))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IConnectionProfile3
  {
    [RemoteAsync]
    IAsyncOperation<IVectorView<AttributedNetworkUsage>> GetAttributedNetworkUsageAsync(
      DateTime startTime,
      DateTime endTime,
      NetworkUsageStates states);
  }
}
