// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Capture.IGraphicsCaptureSession2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Capture
{
  [Guid(741977664, 32046, 20548, 128, 78, 139, 103, 153, 212, 207, 158)]
  [WebHostHidden]
  [ExclusiveTo(typeof (GraphicsCaptureSession))]
  [ContractVersion(typeof (UniversalApiContract), 655360)]
  internal interface IGraphicsCaptureSession2
  {
    bool IsCursorCaptureEnabled { get; set; }
  }
}
