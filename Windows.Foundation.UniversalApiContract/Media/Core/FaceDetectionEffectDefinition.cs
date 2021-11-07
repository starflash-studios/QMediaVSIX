// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.FaceDetectionEffectDefinition
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Media.Effects;

namespace Windows.Media.Core
{
  /// <summary>Represents the definition of a face detection video effect.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [DualApiPartition(version = 167772160)]
  public sealed class FaceDetectionEffectDefinition : 
    IVideoEffectDefinition,
    IFaceDetectionEffectDefinition
  {
    /// <summary>Initializes a new instance of the FaceDetectionEffectDefinition class.</summary>
    [MethodImpl]
    public extern FaceDetectionEffectDefinition();

    /// <summary>Gets a string containing the activatable class ID of the face detection effect definition.</summary>
    /// <returns>The activatable class ID of the face detection effect definition.</returns>
    public extern string ActivatableClassId { [MethodImpl] get; }

    /// <summary>Gets the set of properties for configuring the FaceDetectionEffectDefinition object.</summary>
    /// <returns>The set of properties for configuring the FaceDetectionEffectDefinition object.</returns>
    public extern IPropertySet Properties { [MethodImpl] get; }

    /// <summary>Gets or sets a value that prioritizes the speed of face detection and the quality of detection results.</summary>
    /// <returns>A value that prioritizes the speed of face detection and the quality of detection results.</returns>
    public extern FaceDetectionMode DetectionMode { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets or sets a value indicating whether synchronous face detection is enabled.</summary>
    /// <returns>True if synchronous face detection is enabled; otherwise, false.</returns>
    public extern bool SynchronousDetectionEnabled { [MethodImpl] set; [MethodImpl] get; }
  }
}
