// Decompiled with JetBrains decompiler
// Type: Windows.Media.PlayTo.IPlayToSourceWithPreferredSourceUri
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.PlayTo
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2863813611, 13057, 19908, 175, 186, 178, 242, 237, 150, 53, 160)]
  [ExclusiveTo(typeof (PlayToSource))]
  [Deprecated("PlayToSourceWithPreferredSourceUri may be altered or unavailable for releases after Windows 10. Instead, use CastingSource.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")]
  internal interface IPlayToSourceWithPreferredSourceUri
  {
    Uri PreferredSourceUri { [Deprecated("PlayToSourceWithPreferredSourceUri may be altered or unavailable for releases after Windows 10. Instead, use CastingSource.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] get; [Deprecated("PlayToSourceWithPreferredSourceUri may be altered or unavailable for releases after Windows 10. Instead, use CastingSource.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] set; }
  }
}
