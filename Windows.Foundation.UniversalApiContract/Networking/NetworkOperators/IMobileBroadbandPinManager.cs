// Decompiled with JetBrains decompiler
// Type: Windows.Networking.NetworkOperators.IMobileBroadbandPinManager
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Networking.NetworkOperators
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2203483869, 28191, 19355, 164, 19, 43, 31, 80, 204, 54, 223)]
  [ExclusiveTo(typeof (MobileBroadbandPinManager))]
  internal interface IMobileBroadbandPinManager
  {
    IVectorView<MobileBroadbandPinType> SupportedPins { get; }

    MobileBroadbandPin GetPin(MobileBroadbandPinType pinType);
  }
}
