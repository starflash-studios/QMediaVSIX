// Decompiled with JetBrains decompiler
// Type: Windows.Networking.NetworkOperators.TetheringOperationalState
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.NetworkOperators
{
  /// <summary>Defines values used by the NetworkOperatorTetheringManager.TetheringOperationalState property to indicate the operational state of a device's tethering capabilities.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum TetheringOperationalState
  {
    /// <summary>Current operational state is unknown.</summary>
    Unknown,
    /// <summary>Tethering is on.</summary>
    On,
    /// <summary>Tethering is off.</summary>
    Off,
    /// <summary>The tethering feature is currently in transition between the **On** and **Off** states.</summary>
    InTransition,
  }
}
