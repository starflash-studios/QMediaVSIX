// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.LineDisplayPowerStatus
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.PointOfService
{
  /// <summary>Defines the constants that indicate the power status of a line display.</summary>
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  public enum LineDisplayPowerStatus
  {
    /// <summary>The power state is unknown.</summary>
    Unknown,
    /// <summary>The line display is online.</summary>
    Online,
    /// <summary>The line display is off.</summary>
    Off,
    /// <summary>The line display is offline.</summary>
    Offline,
    /// <summary>The line display is either off or offline.</summary>
    OffOrOffline,
  }
}
