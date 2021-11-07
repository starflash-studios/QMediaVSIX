// Decompiled with JetBrains decompiler
// Type: Windows.Media.PlayTo.IPlayToManager
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.PlayTo
{
  [ExclusiveTo(typeof (PlayToManager))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(4117373038, 7031, 17135, 143, 13, 185, 73, 248, 217, 178, 96)]
  [Deprecated("PlayToManager may be altered or unavailable for releases after Windows 10.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")]
  internal interface IPlayToManager
  {
    event TypedEventHandler<PlayToManager, PlayToSourceRequestedEventArgs> SourceRequested;

    event TypedEventHandler<PlayToManager, PlayToSourceSelectedEventArgs> SourceSelected;

    bool DefaultSourceSelection { [Deprecated("PlayToManager may be altered or unavailable for releases after Windows 10.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] set; [Deprecated("PlayToManager may be altered or unavailable for releases after Windows 10.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] get; }
  }
}
