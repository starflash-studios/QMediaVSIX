// Decompiled with JetBrains decompiler
// Type: Windows.Networking.NetworkOperators.INetworkOperatorTetheringClientManager
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Networking.NetworkOperators
{
  [Guid(2444312598, 36298, 16933, 187, 237, 238, 248, 184, 215, 24, 215)]
  [ExclusiveTo(typeof (NetworkOperatorTetheringManager))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface INetworkOperatorTetheringClientManager
  {
    IVectorView<NetworkOperatorTetheringClient> GetTetheringClients();
  }
}
