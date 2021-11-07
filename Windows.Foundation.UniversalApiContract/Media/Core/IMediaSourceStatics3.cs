// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.IMediaSourceStatics3
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Media.Capture.Frames;

namespace Windows.Media.Core
{
  [Guid(1161441494, 11242, 16674, 159, 115, 234, 206, 4, 82, 110, 53)]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [ExclusiveTo(typeof (MediaSource))]
  internal interface IMediaSourceStatics3
  {
    MediaSource CreateFromMediaFrameSource(MediaFrameSource frameSource);
  }
}
