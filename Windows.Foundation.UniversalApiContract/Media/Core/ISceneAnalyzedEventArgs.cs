// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.ISceneAnalyzedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Core
{
  [Guid(342594952, 10321, 17892, 173, 85, 68, 207, 141, 248, 219, 77)]
  [ExclusiveTo(typeof (SceneAnalyzedEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ISceneAnalyzedEventArgs
  {
    SceneAnalysisEffectFrame ResultFrame { get; }
  }
}
