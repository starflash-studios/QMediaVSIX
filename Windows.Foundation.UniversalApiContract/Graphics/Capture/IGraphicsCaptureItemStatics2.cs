// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Capture.IGraphicsCaptureItemStatics2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI;

namespace Windows.Graphics.Capture
{
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 786432)]
  [ExclusiveTo(typeof (GraphicsCaptureItem))]
  [Guid(999468233, 58756, 22626, 191, 92, 156, 49, 108, 109, 45, 187)]
  internal interface IGraphicsCaptureItemStatics2
  {
    GraphicsCaptureItem TryCreateFromWindowId(WindowId windowId);

    GraphicsCaptureItem TryCreateFromDisplayId(DisplayId displayId);
  }
}
