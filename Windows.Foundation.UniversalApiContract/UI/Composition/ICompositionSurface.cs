// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.ICompositionSurface
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Composition
{
  /// <summary>Represents the content of a surface that can be used to paint the bounds of a SpriteVisual. All surface types that can be used to paint a SpriteVisual must implement this interface. The following classes implement this interface and can be set as content of a SpriteVisual (using a CompositionSurfaceBrush):</summary>
  [WebHostHidden]
  [Guid(354898957, 17095, 18342, 164, 8, 102, 143, 121, 169, 13, 251)]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  public interface ICompositionSurface
  {
  }
}
