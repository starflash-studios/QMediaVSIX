// Decompiled with JetBrains decompiler
// Type: Windows.Media.Audio.IReverbEffectDefinition
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Media.Effects;

namespace Windows.Media.Audio
{
  [Guid(1174841993, 62819, 19722, 143, 110, 240, 205, 223, 243, 93, 132)]
  [ExclusiveTo(typeof (ReverbEffectDefinition))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IReverbEffectDefinition : IAudioEffectDefinition
  {
    double WetDryMix { set; get; }

    uint ReflectionsDelay { set; get; }

    byte ReverbDelay { set; get; }

    byte RearDelay { set; get; }

    byte PositionLeft { set; get; }

    byte PositionRight { set; get; }

    byte PositionMatrixLeft { set; get; }

    byte PositionMatrixRight { set; get; }

    byte EarlyDiffusion { set; get; }

    byte LateDiffusion { set; get; }

    byte LowEQGain { set; get; }

    byte LowEQCutoff { set; get; }

    byte HighEQGain { set; get; }

    byte HighEQCutoff { set; get; }

    double RoomFilterFreq { set; get; }

    double RoomFilterMain { set; get; }

    double RoomFilterHF { set; get; }

    double ReflectionsGain { set; get; }

    double ReverbGain { set; get; }

    double DecayTime { set; get; }

    double Density { set; get; }

    double RoomSize { set; get; }

    bool DisableLateField { set; get; }
  }
}
