// Decompiled with JetBrains decompiler
// Type: Windows.Media.Playback.IMediaPlayerFailedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Playback
{
  [ExclusiveTo(typeof (MediaPlayerFailedEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(658827705, 42979, 20246, 186, 196, 121, 20, 235, 192, 131, 1)]
  internal interface IMediaPlayerFailedEventArgs
  {
    MediaPlayerError Error { get; }

    HResult ExtendedErrorCode { get; }

    string ErrorMessage { get; }
  }
}
