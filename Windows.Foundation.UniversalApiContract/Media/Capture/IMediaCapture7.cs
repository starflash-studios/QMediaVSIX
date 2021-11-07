// Decompiled with JetBrains decompiler
// Type: Windows.Media.Capture.IMediaCapture7
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.WindowManagement;

namespace Windows.Media.Capture
{
  [ExclusiveTo(typeof (MediaCapture))]
  [Guid(2439639298, 34952, 21530, 149, 188, 36, 228, 212, 98, 84, 42)]
  [ContractVersion(typeof (UniversalApiContract), 655360)]
  internal interface IMediaCapture7
  {
    MediaCaptureRelativePanelWatcher CreateRelativePanelWatcher(
      StreamingCaptureMode captureMode,
      DisplayRegion displayRegion);
  }
}
