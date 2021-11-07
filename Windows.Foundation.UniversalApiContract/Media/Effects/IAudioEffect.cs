// Decompiled with JetBrains decompiler
// Type: Windows.Media.Effects.IAudioEffect
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Effects
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (AudioEffect))]
  [Guid(883620433, 37383, 16469, 190, 147, 110, 87, 52, 168, 106, 228)]
  internal interface IAudioEffect
  {
    AudioEffectType AudioEffectType { get; }
  }
}
