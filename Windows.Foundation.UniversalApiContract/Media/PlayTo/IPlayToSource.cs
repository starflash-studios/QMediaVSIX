// Decompiled with JetBrains decompiler
// Type: Windows.Media.PlayTo.IPlayToSource
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.PlayTo
{
  [ExclusiveTo(typeof (PlayToSource))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2131986952, 64439, 19209, 131, 86, 170, 95, 78, 51, 92, 49)]
  [Deprecated("PlayToSource may be altered or unavailable for releases after Windows 10. Instead, use CastingSource.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")]
  internal interface IPlayToSource
  {
    PlayToConnection Connection { [Deprecated("PlayToSource may be altered or unavailable for releases after Windows 10. Instead, use CastingSource.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] get; }

    PlayToSource Next { [Deprecated("PlayToSource may be altered or unavailable for releases after Windows 10. Instead, use CastingSource.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] get; [Deprecated("PlayToSource may be altered or unavailable for releases after Windows 10. Instead, use CastingSource.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] set; }

    [Deprecated("PlayToSource may be altered or unavailable for releases after Windows 10. Instead, use CastingSource.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")]
    void PlayNext();
  }
}
