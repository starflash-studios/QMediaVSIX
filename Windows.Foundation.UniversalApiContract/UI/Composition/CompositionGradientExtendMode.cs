// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.CompositionGradientExtendMode
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Composition
{
  /// <summary>Defines constants that specify how to draw the gradient outside the brush's gradient vector or space.</summary>
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  public enum CompositionGradientExtendMode
  {
    /// <summary>The gradient is not extended.</summary>
    Clamp,
    /// <summary>The gradient is wrapped.</summary>
    Wrap,
    /// <summary>The gradient is repeated in the reverse direction..</summary>
    Mirror,
  }
}
