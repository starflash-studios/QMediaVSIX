// Decompiled with JetBrains decompiler
// Type: Windows.Media.Editing.IMediaOverlayLayerFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Media.Effects;

namespace Windows.Media.Editing
{
  [Guid(2491200627, 41886, 17250, 171, 191, 159, 139, 80, 112, 160, 98)]
  [ExclusiveTo(typeof (MediaOverlayLayer))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IMediaOverlayLayerFactory
  {
    MediaOverlayLayer CreateWithCompositorDefinition(
      IVideoCompositorDefinition compositorDefinition);
  }
}
