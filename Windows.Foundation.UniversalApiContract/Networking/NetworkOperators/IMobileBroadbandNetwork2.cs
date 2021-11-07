// Decompiled with JetBrains decompiler
// Type: Windows.Networking.NetworkOperators.IMobileBroadbandNetwork2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Networking.NetworkOperators
{
  [Guid(1515576098, 25335, 19421, 186, 29, 71, 116, 65, 150, 11, 160)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (MobileBroadbandNetwork))]
  internal interface IMobileBroadbandNetwork2
  {
    [RemoteAsync]
    IAsyncOperation<bool> GetVoiceCallSupportAsync();

    IVectorView<MobileBroadbandUiccApp> RegistrationUiccApps { get; }
  }
}
