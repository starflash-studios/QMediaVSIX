// Decompiled with JetBrains decompiler
// Type: Windows.Media.Audio.ILimiterEffectDefinition
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Media.Effects;

namespace Windows.Media.Audio
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (LimiterEffectDefinition))]
  [Guid(1802853657, 9731, 18362, 189, 235, 57, 5, 94, 52, 134, 220)]
  internal interface ILimiterEffectDefinition : IAudioEffectDefinition
  {
    uint Release { set; get; }

    uint Loudness { set; get; }
  }
}
