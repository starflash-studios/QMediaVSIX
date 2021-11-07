// Decompiled with JetBrains decompiler
// Type: Windows.Media.Capture.IMediaCaptureSettings3
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Graphics.DirectX.Direct3D11;

namespace Windows.Media.Capture
{
  [ExclusiveTo(typeof (MediaCaptureSettings))]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [Guid(809265090, 32856, 19227, 184, 119, 140, 46, 243, 82, 132, 64)]
  internal interface IMediaCaptureSettings3
  {
    IDirect3DDevice Direct3D11Device { get; }
  }
}
