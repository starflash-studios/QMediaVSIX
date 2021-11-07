// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.SceneAnalysisRecommendation
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Core
{
  /// <summary>Specifies the recommended image processing to improve image quality and fidelity of captured images based on the current capture conditions, as determined by the SceneAnalysisEffect.</summary>
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  public enum SceneAnalysisRecommendation
  {
    /// <summary>No image processing is recommended.</summary>
    Standard,
    /// <summary>High Dynamic Range (HDR) processing is recommended.</summary>
    Hdr,
    /// <summary>Low-light processing is recommended.</summary>
    LowLight,
  }
}
