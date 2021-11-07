// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.ICompositionDrawingSurface2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Graphics;

namespace Windows.UI.Composition
{
  [WebHostHidden]
  [Guid(4207995019, 58196, 17640, 142, 61, 196, 136, 13, 90, 33, 63)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [ExclusiveTo(typeof (CompositionDrawingSurface))]
  internal interface ICompositionDrawingSurface2
  {
    SizeInt32 SizeInt32 { get; }

    void Resize(SizeInt32 sizePixels);

    [Overload("Scroll")]
    void Scroll(PointInt32 offset);

    [Overload("ScrollRect")]
    void Scroll(PointInt32 offset, RectInt32 scrollRect);

    [Overload("ScrollWithClip")]
    void ScrollWithClip(PointInt32 offset, RectInt32 clipRect);

    [Overload("ScrollRectWithClip")]
    void ScrollWithClip(PointInt32 offset, RectInt32 clipRect, RectInt32 scrollRect);
  }
}
