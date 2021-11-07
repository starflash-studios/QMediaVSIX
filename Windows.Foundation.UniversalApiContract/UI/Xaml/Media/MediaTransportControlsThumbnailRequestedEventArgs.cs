// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.MediaTransportControlsThumbnailRequestedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.UI.Xaml.Media
{
  /// <summary>Provides data for the MediaTransportControls.ThumbnailRequested event.</summary>
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class MediaTransportControlsThumbnailRequestedEventArgs : 
    IMediaTransportControlsThumbnailRequestedEventArgs
  {
    /// <summary>Sets the source of the thumbnail image.</summary>
    /// <param name="source">The source of the thumbnail image.</param>
    [MethodImpl]
    public extern void SetThumbnailImage(IInputStream source);

    /// <summary>Returns a deferral that can be used to defer the completion of the ThumbnailRequested event while the thumbnail is generated.</summary>
    /// <returns>A deferral object that you can use to identify when the thumbnail request is complete.</returns>
    [MethodImpl]
    public extern Deferral GetDeferral();
  }
}
