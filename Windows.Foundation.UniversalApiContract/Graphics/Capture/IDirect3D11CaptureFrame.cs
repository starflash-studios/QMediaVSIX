// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Capture.IDirect3D11CaptureFrame
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Graphics.DirectX.Direct3D11;

namespace Windows.Graphics.Capture
{
  [WebHostHidden]
  [ExclusiveTo(typeof (Direct3D11CaptureFrame))]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [Guid(4199597603, 14554, 19250, 172, 243, 250, 151, 52, 173, 128, 14)]
  internal interface IDirect3D11CaptureFrame
  {
    IDirect3DSurface Surface { get; }

    TimeSpan SystemRelativeTime { get; }

    SizeInt32 ContentSize { get; }
  }
}
