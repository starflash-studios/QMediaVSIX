// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.IMediaStreamSampleStatics2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Graphics.DirectX.Direct3D11;

namespace Windows.Media.Core
{
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [ExclusiveTo(typeof (MediaStreamSample))]
  [Guid(2667484449, 27974, 18764, 162, 248, 214, 98, 146, 46, 45, 215)]
  internal interface IMediaStreamSampleStatics2
  {
    MediaStreamSample CreateFromDirect3D11Surface(
      IDirect3DSurface surface,
      TimeSpan timestamp);
  }
}
