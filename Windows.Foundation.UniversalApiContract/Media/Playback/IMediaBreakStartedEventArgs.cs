// Decompiled with JetBrains decompiler
// Type: Windows.Media.Playback.IMediaBreakStartedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Playback
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [ExclusiveTo(typeof (MediaBreakStartedEventArgs))]
  [Guid(2826894961, 57300, 17738, 149, 110, 10, 74, 100, 131, 149, 248)]
  internal interface IMediaBreakStartedEventArgs
  {
    MediaBreak MediaBreak { get; }
  }
}
