// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Haptics.ISimpleHapticsController
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Haptics
{
  [Guid(1029144313, 19694, 4582, 181, 53, 0, 27, 220, 6, 171, 59)]
  [ExclusiveTo(typeof (SimpleHapticsController))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  internal interface ISimpleHapticsController
  {
    string Id { get; }

    IVectorView<SimpleHapticsControllerFeedback> SupportedFeedback { get; }

    bool IsIntensitySupported { get; }

    bool IsPlayCountSupported { get; }

    bool IsPlayDurationSupported { get; }

    bool IsReplayPauseIntervalSupported { get; }

    void StopFeedback();

    [Overload("SendHapticFeedback")]
    void SendHapticFeedback(SimpleHapticsControllerFeedback feedback);

    [Overload("SendHapticFeedbackWithIntensity")]
    void SendHapticFeedback(SimpleHapticsControllerFeedback feedback, double intensity);

    void SendHapticFeedbackForDuration(
      SimpleHapticsControllerFeedback feedback,
      double intensity,
      TimeSpan playDuration);

    void SendHapticFeedbackForPlayCount(
      SimpleHapticsControllerFeedback feedback,
      double intensity,
      int playCount,
      TimeSpan replayPauseInterval);
  }
}
