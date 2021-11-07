// Decompiled with JetBrains decompiler
// Type: Windows.Media.Effects.IAudioCaptureEffectsManager
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Media.Effects
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (AudioCaptureEffectsManager))]
  [Guid(2407907953, 909, 17299, 130, 152, 84, 1, 16, 96, 142, 239)]
  internal interface IAudioCaptureEffectsManager
  {
    event TypedEventHandler<AudioCaptureEffectsManager, object> AudioCaptureEffectsChanged;

    IVectorView<AudioEffect> GetAudioCaptureEffects();
  }
}
