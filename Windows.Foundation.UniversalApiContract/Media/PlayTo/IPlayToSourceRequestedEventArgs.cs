// Decompiled with JetBrains decompiler
// Type: Windows.Media.PlayTo.IPlayToSourceRequestedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.PlayTo
{
  [Deprecated("PlayToSourceRequestedEventArgs may be altered or unavailable for releases after Windows 10.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")]
  [ExclusiveTo(typeof (PlayToSourceRequestedEventArgs))]
  [Guid(3318596400, 10719, 20166, 157, 169, 159, 189, 252, 252, 27, 62)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IPlayToSourceRequestedEventArgs
  {
    PlayToSourceRequest SourceRequest { [Deprecated("PlayToSourceRequestedEventArgs may be altered or unavailable for releases after Windows 10.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] get; }
  }
}
