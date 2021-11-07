// Decompiled with JetBrains decompiler
// Type: Windows.Media.PlayTo.IPlayToConnectionErrorEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.PlayTo
{
  [ExclusiveTo(typeof (PlayToConnectionErrorEventArgs))]
  [Guid(3210653094, 35046, 17503, 157, 64, 217, 185, 248, 147, 152, 150)]
  [Deprecated("PlayToConnectionErrorEventArgs may be altered or unavailable for releases after Windows 10. Instead, use CastingConnectionErrorOccurredEventArgs.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IPlayToConnectionErrorEventArgs
  {
    PlayToConnectionError Code { [Deprecated("PlayToConnectionErrorEventArgs may be altered or unavailable for releases after Windows 10. Instead, use CastingConnectionErrorOccurredEventArgs.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] get; }

    string Message { [Deprecated("PlayToConnectionErrorEventArgs may be altered or unavailable for releases after Windows 10. Instead, use CastingConnectionErrorOccurredEventArgs.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] get; }
  }
}
