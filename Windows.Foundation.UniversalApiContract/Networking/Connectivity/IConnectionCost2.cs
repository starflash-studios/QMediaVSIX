// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Connectivity.IConnectionCost2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Connectivity
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (ConnectionCost))]
  [Guid(2383493637, 57865, 17737, 187, 37, 94, 13, 182, 145, 203, 5)]
  internal interface IConnectionCost2
  {
    bool BackgroundDataUsageRestricted { get; }
  }
}
