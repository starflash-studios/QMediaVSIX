// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.IMediaStreamSample2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Graphics.DirectX.Direct3D11;

namespace Windows.Media.Core
{
  [ExclusiveTo(typeof (MediaStreamSample))]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [Guid(1158121105, 64744, 18246, 161, 200, 16, 194, 93, 61, 124, 211)]
  internal interface IMediaStreamSample2
  {
    IDirect3DSurface Direct3D11Surface { get; }
  }
}
