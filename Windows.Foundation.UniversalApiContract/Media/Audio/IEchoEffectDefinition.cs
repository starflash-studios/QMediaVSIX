// Decompiled with JetBrains decompiler
// Type: Windows.Media.Audio.IEchoEffectDefinition
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Media.Effects;

namespace Windows.Media.Audio
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (EchoEffectDefinition))]
  [Guid(239943594, 14008, 19601, 185, 218, 17, 244, 74, 138, 102, 16)]
  internal interface IEchoEffectDefinition : IAudioEffectDefinition
  {
    double WetDryMix { set; get; }

    double Feedback { set; get; }

    double Delay { set; get; }
  }
}
