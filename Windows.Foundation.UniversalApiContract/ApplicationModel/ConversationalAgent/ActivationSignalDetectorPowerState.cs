// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.ConversationalAgent.ActivationSignalDetectorPowerState
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.ConversationalAgent
{
  /// <summary>Specifies the power modes, supported by an ActivationSignalDetector, that describe the power-related conditions under which a detector is allowed to operate.</summary>
  [ContractVersion(typeof (UniversalApiContract), 655360)]
  public enum ActivationSignalDetectorPowerState
  {
    /// <summary>A device that is not currently affected by any power restriction conditions. For example, a laptop that's charging and in active use (with the screen on).</summary>
    HighPower,
    /// <summary>A device in a low-power state but not currently using battery power. For example, a laptop that's charging while in sleep state.</summary>
    ConnectedLowPower,
    /// <summary>A device in a low-power state and using battery power. For example, a laptop in sleep state that's not connected to an external power source.</summary>
    DisconnectedLowPower,
  }
}
