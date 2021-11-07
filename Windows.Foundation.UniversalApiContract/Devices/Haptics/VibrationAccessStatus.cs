// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Haptics.VibrationAccessStatus
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Haptics
{
  /// <summary>Specifies the access rights to the vibration device.</summary>
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  public enum VibrationAccessStatus
  {
    /// <summary>Vibration enabled.</summary>
    Allowed,
    /// <summary>Vibration disabled by user.</summary>
    DeniedByUser,
    /// <summary>Vibration disabled by system.</summary>
    DeniedBySystem,
    /// <summary>Vibration disabled for energy saving.</summary>
    DeniedByEnergySaver,
  }
}
