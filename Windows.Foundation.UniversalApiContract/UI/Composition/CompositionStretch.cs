// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.CompositionStretch
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Composition
{
  /// <summary>Specifies how content is scaled when mapped from its source to a destination space.</summary>
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [WebHostHidden]
  public enum CompositionStretch
  {
    /// <summary>No Scaling. If the size of the content is greater than size of destination, the content is clipped to the bounds of the destination space.</summary>
    None,
    /// <summary>Scale content such that its size is equal to the size of the destination. The aspect ratio of the content is not preserved.</summary>
    Fill,
    /// <summary>Scale content such that its aspect ratio is preserved and it fits entirely within the bounds of the destination space. If the content’s aspect ratio does not match that of the destination, the content will not cover some of the area bound by the destination space. This is the default value for CompositionSurfaceBrush.Stretch.</summary>
    Uniform,
    /// <summary>Scale content such that its aspect ratio is preserved and it fills the entirety of the destination’s bounds. If the content’s aspect ratio does not match that of the destination, the content will be clipped to the bounds of the destination.</summary>
    UniformToFill,
  }
}
