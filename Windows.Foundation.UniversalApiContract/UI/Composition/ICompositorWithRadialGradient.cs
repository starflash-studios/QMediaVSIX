// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.ICompositorWithRadialGradient
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Composition
{
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  [ExclusiveTo(typeof (Compositor))]
  [Guid(2562310567, 36465, 19283, 180, 168, 105, 186, 93, 25, 220, 91)]
  internal interface ICompositorWithRadialGradient
  {
    CompositionRadialGradientBrush CreateRadialGradientBrush();
  }
}
