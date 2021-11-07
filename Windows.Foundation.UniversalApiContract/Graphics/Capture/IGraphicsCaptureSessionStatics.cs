// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Capture.IGraphicsCaptureSessionStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Capture
{
  [WebHostHidden]
  [ExclusiveTo(typeof (GraphicsCaptureSession))]
  [Guid(572826944, 22900, 18858, 178, 50, 8, 130, 83, 111, 76, 181)]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  internal interface IGraphicsCaptureSessionStatics
  {
    bool IsSupported();
  }
}
