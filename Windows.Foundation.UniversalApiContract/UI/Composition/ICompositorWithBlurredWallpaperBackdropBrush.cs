// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.ICompositorWithBlurredWallpaperBackdropBrush
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Composition
{
  [Guid(227520912, 61730, 23437, 159, 221, 84, 59, 13, 142, 183, 243)]
  [ContractVersion(typeof (UniversalApiContract), 851968)]
  [ExclusiveTo(typeof (Compositor))]
  [WebHostHidden]
  internal interface ICompositorWithBlurredWallpaperBackdropBrush
  {
    CompositionBackdropBrush TryCreateBlurredWallpaperBackdropBrush();
  }
}
