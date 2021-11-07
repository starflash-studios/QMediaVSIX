// Decompiled with JetBrains decompiler
// Type: Windows.Media.Audio.IAudioGraphSettings2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Audio
{
  [Guid(1922144135, 19883, 18147, 180, 201, 216, 225, 162, 99, 96, 98)]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [ExclusiveTo(typeof (AudioGraphSettings))]
  internal interface IAudioGraphSettings2
  {
    double MaxPlaybackSpeedFactor { set; get; }
  }
}
