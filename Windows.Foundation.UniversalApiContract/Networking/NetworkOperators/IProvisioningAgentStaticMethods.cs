// Decompiled with JetBrains decompiler
// Type: Windows.Networking.NetworkOperators.IProvisioningAgentStaticMethods
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.NetworkOperators
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(561447136, 33025, 4575, 173, 185, 244, 206, 70, 45, 145, 55)]
  [ExclusiveTo(typeof (ProvisioningAgent))]
  internal interface IProvisioningAgentStaticMethods
  {
    ProvisioningAgent CreateFromNetworkAccountId(string networkAccountId);
  }
}
