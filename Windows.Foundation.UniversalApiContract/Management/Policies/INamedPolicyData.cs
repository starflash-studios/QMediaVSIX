// Decompiled with JetBrains decompiler
// Type: Windows.Management.Policies.INamedPolicyData
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;
using Windows.System;

namespace Windows.Management.Policies
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(953987480, 38316, 16503, 166, 67, 128, 120, 202, 226, 100, 0)]
  [ExclusiveTo(typeof (NamedPolicyData))]
  internal interface INamedPolicyData
  {
    string Area { get; }

    string Name { get; }

    NamedPolicyKind Kind { get; }

    bool IsManaged { get; }

    bool IsUserPolicy { get; }

    User User { get; }

    bool GetBoolean();

    IBuffer GetBinary();

    int GetInt32();

    long GetInt64();

    string GetString();

    event TypedEventHandler<NamedPolicyData, object> Changed;
  }
}
