// Decompiled with JetBrains decompiler
// Type: Windows.Media.Effects.IProcessVideoFrameContext
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Effects
{
  [Guid(661589547, 25697, 16414, 186, 120, 15, 218, 214, 17, 78, 236)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (ProcessVideoFrameContext))]
  internal interface IProcessVideoFrameContext
  {
    VideoFrame InputFrame { get; }

    VideoFrame OutputFrame { get; }
  }
}
