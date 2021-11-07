// Decompiled with JetBrains decompiler
// Type: Windows.Media.PlayTo.IPlayToConnectionStateChangedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.PlayTo
{
  [Guid(1757721871, 3104, 18816, 134, 2, 88, 198, 34, 56, 212, 35)]
  [Deprecated("PlayToConnectionStateChangedEventArgs may be altered or unavailable for releases after Windows 10.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")]
  [ExclusiveTo(typeof (PlayToConnectionStateChangedEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IPlayToConnectionStateChangedEventArgs
  {
    PlayToConnectionState PreviousState { [Deprecated("PlayToConnectionStateChangedEventArgs may be altered or unavailable for releases after Windows 10.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] get; }

    PlayToConnectionState CurrentState { [Deprecated("PlayToConnectionStateChangedEventArgs may be altered or unavailable for releases after Windows 10.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] get; }
  }
}
