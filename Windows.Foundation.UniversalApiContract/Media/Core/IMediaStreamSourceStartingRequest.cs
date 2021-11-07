// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.IMediaStreamSourceStartingRequest
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Core
{
  [ExclusiveTo(typeof (MediaStreamSourceStartingRequest))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(714118116, 13764, 19227, 167, 145, 13, 153, 219, 86, 221, 29)]
  internal interface IMediaStreamSourceStartingRequest
  {
    IReference<TimeSpan> StartPosition { get; }

    MediaStreamSourceStartingRequestDeferral GetDeferral();

    void SetActualStartPosition(TimeSpan position);
  }
}
