// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.ISceneAnalysisEffectFrame2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Core
{
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [ExclusiveTo(typeof (SceneAnalysisEffectFrame))]
  [Guid(760097214, 1567, 18350, 153, 21, 2, 82, 75, 95, 154, 95)]
  internal interface ISceneAnalysisEffectFrame2 : IMediaFrame, IClosable
  {
    SceneAnalysisRecommendation AnalysisRecommendation { get; }
  }
}
