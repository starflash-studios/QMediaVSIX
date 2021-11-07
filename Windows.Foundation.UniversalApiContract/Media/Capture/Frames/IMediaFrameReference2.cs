// Decompiled with JetBrains decompiler
// Type: Windows.Media.Capture.Frames.IMediaFrameReference2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Capture.Frames
{
  [ExclusiveTo(typeof (MediaFrameReference))]
  [Guid(3720101580, 54706, 18927, 131, 106, 148, 125, 152, 155, 128, 193)]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  internal interface IMediaFrameReference2
  {
    AudioMediaFrame AudioMediaFrame { get; }
  }
}
