// Decompiled with JetBrains decompiler
// Type: Windows.Media.PlayTo.IPlayToSourceSelectedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Media.PlayTo
{
  [ExclusiveTo(typeof (PlayToSourceSelectedEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(211649809, 20994, 19915, 140, 103, 171, 218, 18, 187, 60, 18)]
  [Deprecated("PlayToSourceSelectedEventArgs may be altered or unavailable for releases after Windows 10.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")]
  internal interface IPlayToSourceSelectedEventArgs
  {
    string FriendlyName { [Deprecated("PlayToSourceSelectedEventArgs may be altered or unavailable for releases after Windows 10.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] get; }

    IRandomAccessStreamWithContentType Icon { [Deprecated("PlayToSourceSelectedEventArgs may be altered or unavailable for releases after Windows 10.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] get; }

    bool SupportsImage { [Deprecated("PlayToSourceSelectedEventArgs may be altered or unavailable for releases after Windows 10.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] get; }

    bool SupportsAudio { [Deprecated("PlayToSourceSelectedEventArgs may be altered or unavailable for releases after Windows 10.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] get; }

    bool SupportsVideo { [Deprecated("PlayToSourceSelectedEventArgs may be altered or unavailable for releases after Windows 10.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] get; }
  }
}
