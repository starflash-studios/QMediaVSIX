// Decompiled with JetBrains decompiler
// Type: Windows.Media.Capture.IMediaCaptureInitializationSettings3
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Media.Core;

namespace Windows.Media.Capture
{
  [ExclusiveTo(typeof (MediaCaptureInitializationSettings))]
  [Guid(1096831389, 48712, 18224, 129, 4, 12, 246, 233, 233, 121, 72)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IMediaCaptureInitializationSettings3
  {
    IMediaSource AudioSource { set; get; }

    IMediaSource VideoSource { set; get; }
  }
}
