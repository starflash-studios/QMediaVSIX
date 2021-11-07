// Decompiled with JetBrains decompiler
// Type: Windows.Media.PlayTo.IPlayToConnectionTransferredEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.PlayTo
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Deprecated("PlayToConnectionTransferredEventArgs may be altered or unavailable for releases after Windows 10.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")]
  [Guid(4209187130, 1667, 18393, 141, 240, 24, 203, 180, 137, 132, 216)]
  [ExclusiveTo(typeof (PlayToConnectionTransferredEventArgs))]
  internal interface IPlayToConnectionTransferredEventArgs
  {
    PlayToSource PreviousSource { [Deprecated("PlayToConnectionTransferredEventArgs may be altered or unavailable for releases after Windows 10.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] get; }

    PlayToSource CurrentSource { [Deprecated("PlayToConnectionTransferredEventArgs may be altered or unavailable for releases after Windows 10.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] get; }
  }
}
