// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.HighDynamicRangeOutput
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Media.Devices.Core;

namespace Windows.Media.Core
{
  /// <summary>Provides the results of a High Dynamic Range (HDR) analysis operation from the SceneAnalysisEffect.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [DualApiPartition(version = 167772160)]
  public sealed class HighDynamicRangeOutput : IHighDynamicRangeOutput
  {
    /// <summary>Gets a value indicating the certainty of the results of the HDR analysis.</summary>
    /// <returns>A value indicating the certainty of the results of the HDR analysis where 1 is full certainty and 0 is no certainty.</returns>
    public extern double Certainty { [MethodImpl] get; }

    /// <summary>Gets a set of FrameController objects representing the suggested frame controllers settings for capturing a variable photo sequence with the High Dynamic Range (HDR) technique.</summary>
    /// <returns>A set of FrameController objects representing the suggested frame controllers settings.</returns>
    public extern IVectorView<FrameController> FrameControllers { [MethodImpl] get; }
  }
}
