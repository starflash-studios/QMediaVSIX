// Decompiled with JetBrains decompiler
// Type: Windows.Media.Playback.IMediaBreakEndedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Playback
{
  [ExclusiveTo(typeof (MediaBreakEndedEventArgs))]
  [Guid(850997878, 7261, 20462, 135, 50, 35, 109, 195, 168, 133, 128)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface IMediaBreakEndedEventArgs
  {
    MediaBreak MediaBreak { get; }
  }
}
