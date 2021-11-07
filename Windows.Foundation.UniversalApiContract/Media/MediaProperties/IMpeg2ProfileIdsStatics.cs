// Decompiled with JetBrains decompiler
// Type: Windows.Media.MediaProperties.IMpeg2ProfileIdsStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.MediaProperties
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (Mpeg2ProfileIds))]
  [Guid(2757885829, 58746, 16680, 155, 33, 213, 51, 27, 4, 35, 92)]
  internal interface IMpeg2ProfileIdsStatics
  {
    int Simple { get; }

    int Main { get; }

    int SignalNoiseRatioScalable { get; }

    int SpatiallyScalable { get; }

    int High { get; }
  }
}
