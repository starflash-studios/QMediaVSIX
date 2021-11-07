// Decompiled with JetBrains decompiler
// Type: Windows.Media.Capture.ICapturedFrame2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Graphics.Imaging;

namespace Windows.Media.Capture
{
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [ExclusiveTo(typeof (CapturedFrame))]
  [Guid(1413457617, 48504, 18534, 173, 218, 36, 49, 75, 198, 93, 234)]
  internal interface ICapturedFrame2
  {
    CapturedFrameControlValues ControlValues { get; }

    BitmapPropertySet BitmapProperties { get; }
  }
}
