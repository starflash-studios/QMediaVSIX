// Decompiled with JetBrains decompiler
// Type: Windows.Media.Audio.IAudioGraphSettingsFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Media.Render;

namespace Windows.Media.Audio
{
  [Guid(2782469318, 49899, 19041, 162, 20, 29, 102, 215, 95, 131, 218)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (AudioGraphSettings))]
  internal interface IAudioGraphSettingsFactory
  {
    AudioGraphSettings Create(AudioRenderCategory audioRenderCategory);
  }
}
