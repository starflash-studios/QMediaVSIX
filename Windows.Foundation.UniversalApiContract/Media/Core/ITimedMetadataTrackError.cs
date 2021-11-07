// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.ITimedMetadataTrackError
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Core
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3010885909, 16660, 18457, 185, 217, 221, 118, 8, 158, 114, 248)]
  [ExclusiveTo(typeof (TimedMetadataTrackError))]
  internal interface ITimedMetadataTrackError
  {
    TimedMetadataTrackErrorCode ErrorCode { get; }

    HResult ExtendedError { get; }
  }
}
