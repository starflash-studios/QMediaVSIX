// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.ITimedMetadataTrackFailedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Core
{
  [ExclusiveTo(typeof (TimedMetadataTrackFailedEventArgs))]
  [Guid(2776615377, 26505, 19789, 176, 127, 132, 180, 243, 26, 203, 112)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ITimedMetadataTrackFailedEventArgs
  {
    TimedMetadataTrackError Error { get; }
  }
}
