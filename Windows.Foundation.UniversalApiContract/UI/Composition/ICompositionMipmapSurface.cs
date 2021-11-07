// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.ICompositionMipmapSurface
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Graphics;
using Windows.Graphics.DirectX;

namespace Windows.UI.Composition
{
  [Guid(1214474076, 53066, 19228, 158, 206, 197, 236, 12, 43, 47, 230)]
  [WebHostHidden]
  [ExclusiveTo(typeof (CompositionMipmapSurface))]
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  internal interface ICompositionMipmapSurface
  {
    uint LevelCount { get; }

    DirectXAlphaMode AlphaMode { get; }

    DirectXPixelFormat PixelFormat { get; }

    SizeInt32 SizeInt32 { get; }

    CompositionDrawingSurface GetDrawingSurfaceForLevel(uint level);
  }
}
