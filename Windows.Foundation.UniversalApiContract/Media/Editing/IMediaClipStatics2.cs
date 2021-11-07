// Decompiled with JetBrains decompiler
// Type: Windows.Media.Editing.IMediaClipStatics2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Graphics.DirectX.Direct3D11;

namespace Windows.Media.Editing
{
  [Guid(1528682419, 34126, 19867, 135, 125, 71, 116, 165, 86, 205, 18)]
  [ExclusiveTo(typeof (MediaClip))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IMediaClipStatics2
  {
    MediaClip CreateFromSurface(IDirect3DSurface surface, TimeSpan originalDuration);
  }
}
