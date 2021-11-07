// Decompiled with JetBrains decompiler
// Type: Windows.Media.Capture.Frames.IMultiSourceMediaFrameReader
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Capture.Frames
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [ExclusiveTo(typeof (MultiSourceMediaFrameReader))]
  [Guid(2366915586, 63331, 18573, 152, 242, 180, 55, 188, 240, 117, 231)]
  internal interface IMultiSourceMediaFrameReader : IClosable
  {
    event TypedEventHandler<MultiSourceMediaFrameReader, MultiSourceMediaFrameArrivedEventArgs> FrameArrived;

    MultiSourceMediaFrameReference TryAcquireLatestFrame();

    [RemoteAsync]
    IAsyncOperation<MultiSourceMediaFrameReaderStartStatus> StartAsync();

    [RemoteAsync]
    IAsyncAction StopAsync();
  }
}
