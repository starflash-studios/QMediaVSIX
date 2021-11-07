// Decompiled with JetBrains decompiler
// Type: Windows.Media.Audio.IAudioNodeEmitterConeProperties
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Audio
{
  [ExclusiveTo(typeof (AudioNodeEmitterConeProperties))]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(3919260910, 714, 17269, 147, 38, 12, 106, 228, 188, 223, 181)]
  internal interface IAudioNodeEmitterConeProperties
  {
    double InnerAngle { get; }

    double OuterAngle { get; }

    double OuterAngleGain { get; }
  }
}
