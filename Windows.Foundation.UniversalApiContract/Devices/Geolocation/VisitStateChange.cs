// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Geolocation.VisitStateChange
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Geolocation
{
  /// <summary>Contains values that describe a Visit-related state change.</summary>
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  public enum VisitStateChange
  {
    /// <summary>The device is unable to track location at this time.</summary>
    TrackingLost,
    /// <summary>The user arrived at a Visit.</summary>
    Arrived,
    /// <summary>The user departed from a Visit.</summary>
    Departed,
    /// <summary>The user moved significantly since the last Visit.</summary>
    OtherMovement,
  }
}
