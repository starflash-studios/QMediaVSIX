// Decompiled with JetBrains decompiler
// Type: Windows.Media.Audio.IAudioNodeEmitterShapeStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Audio
{
  [ExclusiveTo(typeof (AudioNodeEmitterShape))]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(1471883121, 65445, 19334, 167, 121, 226, 100, 174, 185, 20, 95)]
  internal interface IAudioNodeEmitterShapeStatics
  {
    AudioNodeEmitterShape CreateCone(
      double innerAngle,
      double outerAngle,
      double outerAngleGain);

    AudioNodeEmitterShape CreateOmnidirectional();
  }
}
