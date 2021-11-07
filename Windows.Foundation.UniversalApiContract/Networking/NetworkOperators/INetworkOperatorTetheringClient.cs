// Decompiled with JetBrains decompiler
// Type: Windows.Networking.NetworkOperators.INetworkOperatorTetheringClient
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Networking.NetworkOperators
{
  [Guid(1889346892, 22879, 18503, 187, 48, 100, 105, 53, 84, 41, 24)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (NetworkOperatorTetheringClient))]
  internal interface INetworkOperatorTetheringClient
  {
    string MacAddress { get; }

    IVectorView<HostName> HostNames { get; }
  }
}
