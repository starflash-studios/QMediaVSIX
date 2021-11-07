// Decompiled with JetBrains decompiler
// Type: Windows.Media.Capture.IMediaCaptureRelativePanelWatcher
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Devices.Enumeration;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Capture
{
  [ContractVersion(typeof (UniversalApiContract), 655360)]
  [Guid(2106156390, 1214, 23433, 179, 14, 189, 52, 169, 241, 45, 176)]
  [ExclusiveTo(typeof (MediaCaptureRelativePanelWatcher))]
  internal interface IMediaCaptureRelativePanelWatcher
  {
    Panel RelativePanel { get; }

    event TypedEventHandler<MediaCaptureRelativePanelWatcher, object> Changed;

    void Start();

    void Stop();
  }
}
