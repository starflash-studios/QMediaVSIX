// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Connectivity.IConnectionCost
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Connectivity
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (ConnectionCost))]
  [Guid(3134707753, 13334, 19216, 162, 2, 186, 192, 176, 117, 189, 174)]
  internal interface IConnectionCost
  {
    NetworkCostType NetworkCostType { get; }

    bool Roaming { get; }

    bool OverDataLimit { get; }

    bool ApproachingDataLimit { get; }
  }
}
