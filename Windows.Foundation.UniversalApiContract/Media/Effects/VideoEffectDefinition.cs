// Decompiled with JetBrains decompiler
// Type: Windows.Media.Effects.VideoEffectDefinition
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Media.Effects
{
  /// <summary>Represents a video effect definition.</summary>
  [Activatable(typeof (IVideoEffectDefinitionFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class VideoEffectDefinition : IVideoEffectDefinition
  {
    /// <summary>Creates a new VideoEffectDefinition object with the specified activatable class ID.</summary>
    /// <param name="activatableClassId">The activatable class ID of the video effect definition.</param>
    [MethodImpl]
    public extern VideoEffectDefinition(string activatableClassId);

    /// <summary>Creates a new VideoEffectDefinition object with the specified activatable class ID, configuring the object with the specified settings.</summary>
    /// <param name="activatableClassId">The activatable class ID of the video effect definition.</param>
    /// <param name="props">Configuration properties for the specified video effect definition.</param>
    [MethodImpl]
    public extern VideoEffectDefinition(string activatableClassId, IPropertySet props);

    /// <summary>Gets the activatable class ID of the video effect definition.</summary>
    /// <returns>The activatable class ID of the video effect definition, such as "Windows.Media.VideoStabilizationEffect".</returns>
    public extern string ActivatableClassId { [MethodImpl] get; }

    /// <summary>Gets the set of properties for configuring the VideoEffectDefinition object.</summary>
    /// <returns>The set of properties for the video effect definition, represented as tuples.</returns>
    public extern IPropertySet Properties { [MethodImpl] get; }
  }
}
