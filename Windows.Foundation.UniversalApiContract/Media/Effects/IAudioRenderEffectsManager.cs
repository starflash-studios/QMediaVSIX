// Decompiled with JetBrains decompiler
// Type: Windows.Media.Effects.IAudioRenderEffectsManager
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Media.Effects
{
  [Guid(1305053542, 34641, 17074, 191, 203, 57, 202, 120, 100, 189, 71)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (AudioRenderEffectsManager))]
  internal interface IAudioRenderEffectsManager
  {
    event TypedEventHandler<AudioRenderEffectsManager, object> AudioRenderEffectsChanged;

    IVectorView<AudioEffect> GetAudioRenderEffects();
  }
}
