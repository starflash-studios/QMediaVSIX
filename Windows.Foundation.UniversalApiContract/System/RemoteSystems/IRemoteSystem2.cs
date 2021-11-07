// Decompiled with JetBrains decompiler
// Type: Windows.System.RemoteSystems.IRemoteSystem2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.RemoteSystems
{
  [ExclusiveTo(typeof (RemoteSystem))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(165668076, 64395, 18952, 167, 88, 104, 118, 67, 93, 118, 158)]
  internal interface IRemoteSystem2
  {
    bool IsAvailableBySpatialProximity { get; }

    [RemoteAsync]
    IAsyncOperation<bool> GetCapabilitySupportedAsync(string capabilityName);
  }
}
