// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Haptics.SimpleHapticsControllerFeedback
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Haptics
{
  /// <summary>Provides access to the feedback behaviors supported by the haptic input device.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [DualApiPartition(version = 167772163)]
  public sealed class SimpleHapticsControllerFeedback : ISimpleHapticsControllerFeedback
  {
    /// <summary>Gets the haptic waveform type for the haptic input device.</summary>
    /// <returns>An unsigned 16-bit waveform ID (based on the Haptic Usage Page HID specification.</returns>
    public extern ushort Waveform { [MethodImpl] get; }

    /// <summary>Gets the feedback duration for the haptic input device.</summary>
    /// <returns>The time period, expressed in 100-nanosecond units.</returns>
    public extern TimeSpan Duration { [MethodImpl] get; }
  }
}
