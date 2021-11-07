// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.TimedTextSource
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Media.Core
{
  /// <summary>Represents a source of timed text data.</summary>
  [Static(typeof (ITimedTextSourceStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [DualApiPartition(version = 167772160)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [Static(typeof (ITimedTextSourceStatics2), 262144, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class TimedTextSource : ITimedTextSource
  {
    /// <summary>Occurs when the TimedTextSource is resolved.</summary>
    public extern event TypedEventHandler<TimedTextSource, TimedTextSourceResolveResultEventArgs> Resolved;

    /// <summary>Creates a new instance of TimedTextSource that uses image-based subtitles from the provided image and index streams.</summary>
    /// <param name="stream">A stream containing the image data for image-based subtitles.</param>
    /// <param name="indexStream">A stream containing the index data for image-based subtitles.</param>
    /// <returns>The new timed text source.</returns>
    [Overload("CreateFromStreamWithIndex")]
    [MethodImpl]
    public static extern TimedTextSource CreateFromStreamWithIndex(
      IRandomAccessStream stream,
      IRandomAccessStream indexStream);

    [Overload("CreateFromUriWithIndex")]
    [MethodImpl]
    public static extern TimedTextSource CreateFromUriWithIndex(
      Uri uri,
      Uri indexUri);

    /// <summary>Creates a new instance of TimedTextSource that uses image-based subtitles from the provided image and index streams and sets the default language.</summary>
    /// <param name="stream">A stream containing the image data for image-based subtitles.</param>
    /// <param name="indexStream">A stream containing the index data for image-based subtitles.</param>
    /// <param name="defaultLanguage">A string indicating the default language for the timed text source.</param>
    /// <returns>The new timed text source.</returns>
    [Overload("CreateFromStreamWithIndexAndLanguage")]
    [MethodImpl]
    public static extern TimedTextSource CreateFromStreamWithIndex(
      IRandomAccessStream stream,
      IRandomAccessStream indexStream,
      string defaultLanguage);

    [Overload("CreateFromUriWithIndexAndLanguage")]
    [MethodImpl]
    public static extern TimedTextSource CreateFromUriWithIndex(
      Uri uri,
      Uri indexUri,
      string defaultLanguage);

    /// <summary>Creates a new instance of TimedTextSource from the provided stream.</summary>
    /// <param name="stream">The stream from which the timed text source is created.</param>
    /// <returns>The new timed text source.</returns>
    [Overload("CreateFromStream")]
    [MethodImpl]
    public static extern TimedTextSource CreateFromStream(IRandomAccessStream stream);

    [Overload("CreateFromUri")]
    [MethodImpl]
    public static extern TimedTextSource CreateFromUri(Uri uri);

    /// <summary>Creates a new instance of TimedTextSource with the specified default language from the provided stream.</summary>
    /// <param name="stream">The stream from which the timed text source is created.</param>
    /// <param name="defaultLanguage">A string specifying the default language for the timed text source.</param>
    /// <returns>The new timed text source.</returns>
    [Overload("CreateFromStreamWithLanguage")]
    [MethodImpl]
    public static extern TimedTextSource CreateFromStream(
      IRandomAccessStream stream,
      string defaultLanguage);

    [Overload("CreateFromUriWithLanguage")]
    [MethodImpl]
    public static extern TimedTextSource CreateFromUri(
      Uri uri,
      string defaultLanguage);
  }
}
