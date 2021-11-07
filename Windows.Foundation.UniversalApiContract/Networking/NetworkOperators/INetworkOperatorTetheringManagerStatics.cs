// Decompiled with JetBrains decompiler
// Type: Windows.Networking.NetworkOperators.INetworkOperatorTetheringManagerStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.NetworkOperators
{
  [ExclusiveTo(typeof (NetworkOperatorTetheringManager))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1052555980, 63683, 16476, 153, 100, 112, 161, 238, 171, 225, 148)]
  internal interface INetworkOperatorTetheringManagerStatics
  {
    TetheringCapability GetTetheringCapability(string networkAccountId);

    NetworkOperatorTetheringManager CreateFromNetworkAccountId(
      string networkAccountId);
  }
}
