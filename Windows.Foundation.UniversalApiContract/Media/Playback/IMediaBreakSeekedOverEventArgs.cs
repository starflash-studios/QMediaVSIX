// Decompiled with JetBrains decompiler
// Type: Windows.Media.Playback.IMediaBreakSeekedOverEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Media.Playback
{
  [ExclusiveTo(typeof (MediaBreakSeekedOverEventArgs))]
  [Guid(3853150022, 1542, 17554, 185, 211, 195, 200, 253, 224, 164, 234)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface IMediaBreakSeekedOverEventArgs
  {
    IVectorView<MediaBreak> SeekedOverBreaks { get; }

    TimeSpan OldPosition { get; }

    TimeSpan NewPosition { get; }
  }
}
