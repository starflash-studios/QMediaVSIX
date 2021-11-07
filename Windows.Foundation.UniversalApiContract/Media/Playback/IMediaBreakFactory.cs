// Decompiled with JetBrains decompiler
// Type: Windows.Media.Playback.IMediaBreakFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Playback
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(1159127042, 6368, 16505, 139, 95, 211, 52, 149, 193, 93, 46)]
  [ExclusiveTo(typeof (MediaBreak))]
  internal interface IMediaBreakFactory
  {
    MediaBreak Create(MediaBreakInsertionMethod insertionMethod);

    MediaBreak CreateWithPresentationPosition(
      MediaBreakInsertionMethod insertionMethod,
      TimeSpan presentationPosition);
  }
}
