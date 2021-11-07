// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.MagneticStripeReaderAuthenticationProtocol
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.PointOfService
{
  /// <summary>Defines the constants that indicates the authentication protocol supported by the device.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum MagneticStripeReaderAuthenticationProtocol
  {
    /// <summary>The device does not support device authentication.</summary>
    None,
    /// <summary>The device supports challenge response protocol.</summary>
    ChallengeResponse,
  }
}
