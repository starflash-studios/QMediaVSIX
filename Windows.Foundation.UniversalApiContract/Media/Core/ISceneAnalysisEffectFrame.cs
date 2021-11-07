// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.ISceneAnalysisEffectFrame
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Media.Capture;

namespace Windows.Media.Core
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3635482188, 32729, 17121, 133, 235, 101, 114, 194, 151, 201, 135)]
  [ExclusiveTo(typeof (SceneAnalysisEffectFrame))]
  internal interface ISceneAnalysisEffectFrame : IMediaFrame, IClosable
  {
    CapturedFrameControlValues FrameControlValues { get; }

    HighDynamicRangeOutput HighDynamicRange { get; }
  }
}
