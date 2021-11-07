// Decompiled with JetBrains decompiler
// Type: Windows.Gaming.Input.Headset
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Devices.Power;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Gaming.Input
{
  /// <summary>Contains information about an audio headset attached to a gamepad.</summary>
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 167772160)]
  public sealed class Headset : IHeadset, IGameControllerBatteryInfo
  {
    /// <summary>The XAudio endpoint ID for the headset's audio capture device.</summary>
    /// <returns>The XAudio endpoint ID for the headset's audio capture device.</returns>
    public extern string CaptureDeviceId { [MethodImpl] get; }

    /// <summary>The XAudio enpoint ID for the headset's audio render device.</summary>
    /// <returns>The XAudio enpoint ID for the headset's audio render device.</returns>
    public extern string RenderDeviceId { [MethodImpl] get; }

    /// <summary>Gets information about the headset's current battery state.</summary>
    /// <returns>Information about the headset's current battery state.</returns>
    [MethodImpl]
    public extern BatteryReport TryGetBatteryReport();
  }
}
