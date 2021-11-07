// Decompiled with JetBrains decompiler
// Type: Windows.Media.Capture.IMediaCaptureInitializationSettings6
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Capture
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(3001183047, 15793, 19763, 171, 99, 15, 250, 9, 5, 101, 133)]
  [ExclusiveTo(typeof (MediaCaptureInitializationSettings))]
  internal interface IMediaCaptureInitializationSettings6
  {
    bool AlwaysPlaySystemShutterSound { get; set; }
  }
}
