// Decompiled with JetBrains decompiler
// Type: Windows.Media.Effects.VideoCompositorDefinition
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Media.Effects
{
  /// <summary>Represents the definition of a custom video compositor.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [Activatable(typeof (IVideoCompositorDefinitionFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class VideoCompositorDefinition : IVideoCompositorDefinition
  {
    /// <summary>Initializes a new instance of the VideoCompositorDefinition class.</summary>
    /// <param name="activatableClassId">The activatable class ID of the video compositor.</param>
    [MethodImpl]
    public extern VideoCompositorDefinition(string activatableClassId);

    /// <summary>Initializes a new instance of the VideoCompositorDefinition class.</summary>
    /// <param name="activatableClassId">The activatable class ID of the video compositor.</param>
    /// <param name="props">The set of properties for configuring the video compositor object.</param>
    [MethodImpl]
    public extern VideoCompositorDefinition(string activatableClassId, IPropertySet props);

    /// <summary>Gets the activatable class ID of the video compositor.</summary>
    /// <returns>The activatable class ID of the video compositor.</returns>
    public extern string ActivatableClassId { [MethodImpl] get; }

    /// <summary>Gets the set of properties for configuring the video compositor object.</summary>
    /// <returns>The set of properties for configuring the video compositor object.</returns>
    public extern IPropertySet Properties { [MethodImpl] get; }
  }
}
