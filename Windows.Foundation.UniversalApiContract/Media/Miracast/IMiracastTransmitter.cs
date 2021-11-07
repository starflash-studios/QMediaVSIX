// Decompiled with JetBrains decompiler
// Type: Windows.Media.Miracast.IMiracastTransmitter
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Media.Miracast
{
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  [Guid(875395581, 11876, 21768, 138, 48, 131, 61, 30, 172, 112, 208)]
  [ExclusiveTo(typeof (MiracastTransmitter))]
  internal interface IMiracastTransmitter
  {
    string Name { get; set; }

    MiracastTransmitterAuthorizationStatus AuthorizationStatus { get; set; }

    IVectorView<MiracastReceiverConnection> GetConnections();

    string MacAddress { get; }

    DateTime LastConnectionTime { get; }
  }
}
