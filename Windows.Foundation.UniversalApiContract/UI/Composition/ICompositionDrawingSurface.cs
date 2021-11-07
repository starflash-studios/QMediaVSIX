// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.ICompositionDrawingSurface
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Graphics.DirectX;

namespace Windows.UI.Composition
{
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [ExclusiveTo(typeof (CompositionDrawingSurface))]
  [Guid(2707866368, 64208, 19729, 158, 103, 228, 51, 22, 47, 244, 158)]
  [WebHostHidden]
  internal interface ICompositionDrawingSurface
  {
    DirectXAlphaMode AlphaMode { get; }

    DirectXPixelFormat PixelFormat { get; }

    Size Size { get; }
  }
}
