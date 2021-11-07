// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.SceneAnalysisEffect
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Media.Core
{
  /// <summary>Represents an effect that analyzes video frames to determine if any of the supported variable photo sequence capture techniques may produce a higher-quality captured image.</summary>
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 167772160)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class SceneAnalysisEffect : ISceneAnalysisEffect, IMediaExtension
  {
    /// <summary>Gets a HighDynamicRangeControl object that is used to enable or disable High Dynamic Range (HDR) analysis.</summary>
    /// <returns>A HighDynamicRangeControl object that is used to enable or disable High Dynamic Range (HDR) analysis.</returns>
    public extern HighDynamicRangeControl HighDynamicRangeAnalyzer { [MethodImpl] get; }

    /// <summary>Gets or sets the duration of the time window during which video frames are analyzed.</summary>
    /// <returns>The duration of the time window during which video frames are analyzed.</returns>
    public extern TimeSpan DesiredAnalysisInterval { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Raised when the scene analysis is complete. See SceneAnalyzedEventArgs</summary>
    public extern event TypedEventHandler<SceneAnalysisEffect, SceneAnalyzedEventArgs> SceneAnalyzed;

    /// <summary>Sets properties on the IMediaExtension.</summary>
    /// <param name="configuration">The property set.</param>
    [MethodImpl]
    public extern void SetProperties(IPropertySet configuration);
  }
}
