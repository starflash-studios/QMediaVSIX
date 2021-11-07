// Decompiled with JetBrains decompiler
// Type: Windows.Management.Policies.INamedPolicyStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.System;

namespace Windows.Management.Policies
{
  [ExclusiveTo(typeof (NamedPolicy))]
  [Guid(2138651623, 30404, 16472, 140, 173, 103, 102, 44, 208, 95, 13)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  internal interface INamedPolicyStatics
  {
    NamedPolicyData GetPolicyFromPath(string area, string name);

    NamedPolicyData GetPolicyFromPathForUser(User user, string area, string name);
  }
}
