// Decompiled with JetBrains decompiler
// Type: Windows.Devices.WiFiDirect.Services.IWiFiDirectServiceRemotePortAddedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Networking;

namespace Windows.Devices.WiFiDirect.Services
{
  [ExclusiveTo(typeof (WiFiDirectServiceRemotePortAddedEventArgs))]
  [Guid(3570318017, 16339, 20238, 183, 189, 120, 41, 6, 244, 68, 17)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IWiFiDirectServiceRemotePortAddedEventArgs
  {
    IVectorView<EndpointPair> EndpointPairs { get; }

    WiFiDirectServiceIPProtocol Protocol { get; }
  }
}
