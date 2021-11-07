// Decompiled with JetBrains decompiler
// Type: Windows.Media.MediaProperties.IH264ProfileIdsStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.MediaProperties
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (H264ProfileIds))]
  [Guid(946162855, 33898, 20375, 162, 229, 195, 161, 91, 191, 112, 253)]
  internal interface IH264ProfileIdsStatics
  {
    int ConstrainedBaseline { get; }

    int Baseline { get; }

    int Extended { get; }

    int Main { get; }

    int High { get; }

    int High10 { get; }

    int High422 { get; }

    int High444 { get; }

    int StereoHigh { get; }

    int MultiviewHigh { get; }
  }
}
