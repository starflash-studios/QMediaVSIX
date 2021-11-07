// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Connectivity.IConnectionProfileFilter
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Connectivity
{
  [Guid(541883592, 48429, 20109, 164, 179, 69, 94, 195, 55, 56, 138)]
  [ExclusiveTo(typeof (ConnectionProfileFilter))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IConnectionProfileFilter
  {
    bool IsConnected { set; get; }

    bool IsWwanConnectionProfile { set; get; }

    bool IsWlanConnectionProfile { set; get; }

    NetworkCostType NetworkCostType { set; get; }

    IReference<Guid> ServiceProviderGuid { set; get; }
  }
}
