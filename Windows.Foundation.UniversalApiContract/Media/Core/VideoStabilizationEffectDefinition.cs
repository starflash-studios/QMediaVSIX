// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.VideoStabilizationEffectDefinition
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
  /// <summary>Represents the definition of a video stabilization effect.</summary>
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 167772160)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  public sealed class VideoStabilizationEffectDefinition : IVideoEffectDefinition
  {
    /// <summary>Initializes a new instance of the VideoStabilizationEffectDefinition class.</summary>
    [MethodImpl]
    public extern VideoStabilizationEffectDefinition();

    /// <summary>Gets a string containing the activatable class ID of the video stabilization effect definition.</summary>
    /// <returns>The activatable class ID of the video stabilization detection effect definition</returns>
    public extern string ActivatableClassId { [MethodImpl] get; }

    /// <summary>Gets the set of properties for configuring the VideoStabilizationEffectDefinition object.</summary>
    /// <returns>The set of properties for configuring the VideoStabilizationEffectDefinition object.</returns>
    public extern IPropertySet Properties { [MethodImpl] get; }
  }
}
