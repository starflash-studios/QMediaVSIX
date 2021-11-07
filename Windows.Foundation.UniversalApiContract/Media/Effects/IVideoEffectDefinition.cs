// Decompiled with JetBrains decompiler
// Type: Windows.Media.Effects.IVideoEffectDefinition
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Media.Effects
{
  /// <summary>Exposes the methods and properties of a VideoEffectDefinition object. Implement this interface when you create a custom video effect definition.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(972262640, 36111, 20286, 132, 252, 45, 70, 165, 41, 121, 67)]
  public interface IVideoEffectDefinition
  {
    /// <summary>The activatable class ID of the video effect definition.</summary>
    /// <returns>The activatable class ID of the video effect definition, such as "Windows.Media.VideoStabilizationEffect".</returns>
    string ActivatableClassId { get; }

    /// <summary>The set of properties for configuring the VideoEffectDefinition object.</summary>
    /// <returns>The set of properties for the video effect definition, represented as tuples.</returns>
    IPropertySet Properties { get; }
  }
}
