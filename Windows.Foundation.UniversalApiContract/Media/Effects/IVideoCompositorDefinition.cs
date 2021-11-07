// Decompiled with JetBrains decompiler
// Type: Windows.Media.Effects.IVideoCompositorDefinition
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Media.Effects
{
  /// <summary>The interface defining a custom video compositor definition.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2034677968, 8208, 19171, 154, 178, 44, 239, 66, 237, 212, 210)]
  public interface IVideoCompositorDefinition
  {
    /// <summary>Gets the activatable class ID of the video compositor.</summary>
    /// <returns>The activatable class ID of the video compositor.</returns>
    string ActivatableClassId { get; }

    /// <summary>Gets the set of properties for configuring the video compositor object.</summary>
    /// <returns>The set of properties for configuring the video compositor object.</returns>
    IPropertySet Properties { get; }
  }
}
