// Decompiled with JetBrains decompiler
// Type: Windows.Media.PlayTo.IPlaybackRateChangeRequestedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.PlayTo
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (PlaybackRateChangeRequestedEventArgs))]
  [Guid(257319342, 11400, 19658, 133, 64, 213, 134, 9, 93, 19, 165)]
  internal interface IPlaybackRateChangeRequestedEventArgs
  {
    double Rate { get; }
  }
}
