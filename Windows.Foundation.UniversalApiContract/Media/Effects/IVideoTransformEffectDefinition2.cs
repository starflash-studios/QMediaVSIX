// Decompiled with JetBrains decompiler
// Type: Windows.Media.Effects.IVideoTransformEffectDefinition2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Effects
{
  [ExclusiveTo(typeof (VideoTransformEffectDefinition))]
  [Guid(4037544095, 26312, 18068, 159, 217, 17, 54, 171, 247, 68, 74)]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  internal interface IVideoTransformEffectDefinition2
  {
    VideoTransformSphericalProjection SphericalProjection { get; }
  }
}
