// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Capture.IGraphicsCaptureSession3
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Capture
{
  [Guid(4073576806, 8878, 24225, 149, 150, 58, 40, 147, 68, 195, 190)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 786432)]
  [ExclusiveTo(typeof (GraphicsCaptureSession))]
  internal interface IGraphicsCaptureSession3
  {
    bool IsBorderRequired { get; set; }
  }
}
