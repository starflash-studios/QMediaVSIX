// Decompiled with JetBrains decompiler
// Type: Windows.Media.Editing.IMediaOverlayLayer
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Media.Effects;

namespace Windows.Media.Editing
{
  [Guid(2799286871, 61146, 18118, 187, 229, 227, 152, 200, 65, 104, 172)]
  [ExclusiveTo(typeof (MediaOverlayLayer))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IMediaOverlayLayer
  {
    MediaOverlayLayer Clone();

    IVector<MediaOverlay> Overlays { get; }

    IVideoCompositorDefinition CustomCompositorDefinition { get; }
  }
}
