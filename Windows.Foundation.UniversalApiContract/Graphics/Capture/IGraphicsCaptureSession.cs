// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Capture.IGraphicsCaptureSession
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Capture
{
  [ExclusiveTo(typeof (GraphicsCaptureSession))]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [Guid(2169389737, 63247, 19159, 147, 155, 253, 220, 198, 235, 136, 13)]
  internal interface IGraphicsCaptureSession
  {
    void StartCapture();
  }
}
