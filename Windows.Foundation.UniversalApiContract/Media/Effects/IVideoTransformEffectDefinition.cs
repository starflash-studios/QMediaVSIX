// Decompiled with JetBrains decompiler
// Type: Windows.Media.Effects.IVideoTransformEffectDefinition
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Media.MediaProperties;
using Windows.Media.Transcoding;
using Windows.UI;

namespace Windows.Media.Effects
{
  [Guid(2523183978, 7846, 19110, 128, 116, 171, 232, 133, 30, 202, 226)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (VideoTransformEffectDefinition))]
  internal interface IVideoTransformEffectDefinition : IVideoEffectDefinition
  {
    Color PaddingColor { get; set; }

    Size OutputSize { get; set; }

    Rect CropRectangle { get; set; }

    MediaRotation Rotation { get; set; }

    MediaMirroringOptions Mirror { get; set; }

    MediaVideoProcessingAlgorithm ProcessingAlgorithm { set; get; }
  }
}
