// Decompiled with JetBrains decompiler
// Type: Windows.Media.PlayTo.IPlayToSourceRequest
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.PlayTo
{
  [Deprecated("PlayToSourceRequest may be altered or unavailable for releases after Windows 10.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")]
  [Guid(4166534757, 25844, 17568, 172, 13, 70, 141, 43, 143, 218, 131)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (PlayToSourceRequest))]
  internal interface IPlayToSourceRequest
  {
    DateTime Deadline { [Deprecated("PlayToSourceRequest may be altered or unavailable for releases after Windows 10.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] get; }

    [Deprecated("PlayToSourceRequest may be altered or unavailable for releases after Windows 10.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")]
    void DisplayErrorString(string errorString);

    [Deprecated("PlayToSourceRequest may be altered or unavailable for releases after Windows 10.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")]
    PlayToSourceDeferral GetDeferral();

    [Deprecated("PlayToSourceRequest may be altered or unavailable for releases after Windows 10.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")]
    void SetSource(PlayToSource value);
  }
}
