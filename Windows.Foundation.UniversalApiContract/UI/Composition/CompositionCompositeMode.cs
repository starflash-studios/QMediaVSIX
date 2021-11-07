// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.CompositionCompositeMode
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Composition
{
  /// <summary>Determines how a non-opaque visual's content is blended with the background content behind the visual.</summary>
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  public enum CompositionCompositeMode
  {
    /// <summary>Inherits mode from parent visual.</summary>
    Inherit,
    /// <summary>The standard Composite Mode. Colors are blended with per-pixel transparency.</summary>
    SourceOver,
    /// <summary>The visual content's colors are inverted.</summary>
    DestinationInvert,
    /// <summary>Visual content's colors subtract for color channels in the background.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 196608)] MinBlend,
  }
}
