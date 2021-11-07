// Decompiled with JetBrains decompiler
// Type: Windows.Networking.NetworkOperators.INetworkOperatorTetheringManagerStatics3
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Networking.Connectivity;

namespace Windows.Networking.NetworkOperators
{
  [Guid(2413473206, 19193, 20257, 155, 88, 213, 62, 159, 36, 35, 30)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [ExclusiveTo(typeof (NetworkOperatorTetheringManager))]
  internal interface INetworkOperatorTetheringManagerStatics3
  {
    [Overload("CreateFromConnectionProfileWithTargetAdapter")]
    NetworkOperatorTetheringManager CreateFromConnectionProfile(
      ConnectionProfile profile,
      NetworkAdapter adapter);
  }
}
