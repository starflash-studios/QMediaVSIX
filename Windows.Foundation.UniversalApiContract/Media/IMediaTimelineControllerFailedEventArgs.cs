// Decompiled with JetBrains decompiler
// Type: Windows.Media.IMediaTimelineControllerFailedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(2283927581, 15991, 17403, 190, 38, 79, 200, 122, 4, 72, 52)]
  [ExclusiveTo(typeof (MediaTimelineControllerFailedEventArgs))]
  internal interface IMediaTimelineControllerFailedEventArgs
  {
    HResult ExtendedError { get; }
  }
}
