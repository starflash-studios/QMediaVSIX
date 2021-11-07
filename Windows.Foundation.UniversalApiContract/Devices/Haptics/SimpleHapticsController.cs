// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Haptics.SimpleHapticsController
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Haptics
{
  /// <summary>Provides access to a single haptic input device.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [DualApiPartition(version = 167772163)]
  public sealed class SimpleHapticsController : ISimpleHapticsController
  {
    /// <summary>Gets the identifier for the haptic input device.</summary>
    /// <returns>The Global Unique Identifier (GUID) used to identify a single input device.</returns>
    public extern string Id { [MethodImpl] get; }

    /// <summary>Gets the types of feedback supported by the haptic input device.</summary>
    /// <returns>The collection of feedback types supported, including behavior such as duration.</returns>
    public extern IVectorView<SimpleHapticsControllerFeedback> SupportedFeedback { [MethodImpl] get; }

    /// <summary>Gets whether the haptic input device supports feedback intensity.</summary>
    /// <returns>**true** if feedback intensity is supported. Otherwise, **false**.</returns>
    public extern bool IsIntensitySupported { [MethodImpl] get; }

    /// <summary>Gets whether the haptic input device supports feedback counts.</summary>
    /// <returns>**true** if feedback counts are supported. Otherwise, **false**.</returns>
    public extern bool IsPlayCountSupported { [MethodImpl] get; }

    /// <summary>Gets whether the haptic input device supports feedback duration.</summary>
    /// <returns>**true** if duration is supported. Otherwise, **false**.</returns>
    public extern bool IsPlayDurationSupported { [MethodImpl] get; }

    /// <summary>Gets whether the haptic input device supports pause intervals between feedback cycles.</summary>
    /// <returns>**true** if intervals are supported. Otherwise, **false**.</returns>
    public extern bool IsReplayPauseIntervalSupported { [MethodImpl] get; }

    /// <summary>Terminates haptic feedback by the input device.</summary>
    [MethodImpl]
    public extern void StopFeedback();

    /// <summary>Start haptic feedback by the input device.</summary>
    /// <param name="feedback">The type of haptic feedback.</param>
    [Overload("SendHapticFeedback")]
    [MethodImpl]
    public extern void SendHapticFeedback(SimpleHapticsControllerFeedback feedback);

    /// <summary>Start haptic feedback by the input device with the specified intensity.</summary>
    /// <param name="feedback">The type of haptic feedback.</param>
    /// <param name="intensity">The strength of the haptic feedback based on the capability of the input device.</param>
    [Overload("SendHapticFeedbackWithIntensity")]
    [MethodImpl]
    public extern void SendHapticFeedback(
      SimpleHapticsControllerFeedback feedback,
      double intensity);

    [MethodImpl]
    public extern void SendHapticFeedbackForDuration(
      SimpleHapticsControllerFeedback feedback,
      double intensity,
      TimeSpan playDuration);

    [MethodImpl]
    public extern void SendHapticFeedbackForPlayCount(
      SimpleHapticsControllerFeedback feedback,
      double intensity,
      int playCount,
      TimeSpan replayPauseInterval);
  }
}
