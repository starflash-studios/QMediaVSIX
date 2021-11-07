// Decompiled with JetBrains decompiler
// Type: Windows.Networking.NetworkOperators.MobileBroadbandModemStatus
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.NetworkOperators
{
  /// <summary>Specifies the status of a request to set the modem passthrough status by calling SetIsPassthroughEnabledAsync.</summary>
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  public enum MobileBroadbandModemStatus
  {
    /// <summary>The call was successful.</summary>
    Success,
    /// <summary>An unspecified failure occurred.</summary>
    OtherFailure,
    /// <summary>The modem is busy.</summary>
    Busy,
    /// <summary>The modem does not support the request.</summary>
    NoDeviceSupport,
  }
}
