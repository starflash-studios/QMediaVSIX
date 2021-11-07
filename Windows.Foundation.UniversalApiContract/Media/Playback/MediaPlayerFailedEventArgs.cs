// Decompiled with JetBrains decompiler
// Type: Windows.Media.Playback.MediaPlayerFailedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Playback
{
  /// <summary>Provides the data for MediaFailed events.</summary>
  [DualApiPartition(version = 167772160)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class MediaPlayerFailedEventArgs : IMediaPlayerFailedEventArgs
  {
    /// <summary>Gets the MediaPlayerError value for the error that triggered the event.</summary>
    /// <returns>The MediaPlayerError value for the error that triggered the event.</returns>
    public extern MediaPlayerError Error { [MethodImpl] get; }

    /// <summary>Gets an HResult that indicates any extra data about the error that occurred.</summary>
    /// <returns>An HResult that indicates any extra data about the error that occurred.</returns>
    public extern HResult ExtendedErrorCode { [MethodImpl] get; }

    /// <summary>Gets a string describing the error that occurred.</summary>
    /// <returns>String describing the error that occurred.</returns>
    public extern string ErrorMessage { [MethodImpl] get; }
  }
}
