// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Connectivity.IConnectionProfile5
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Connectivity
{
  [ExclusiveTo(typeof (ConnectionProfile))]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [Guid(2234916551, 40051, 19424, 143, 20, 87, 142, 236, 113, 238, 14)]
  internal interface IConnectionProfile5
  {
    bool CanDelete { get; }

    [RemoteAsync]
    IAsyncOperation<ConnectionProfileDeleteStatus> TryDeleteAsync();
  }
}
