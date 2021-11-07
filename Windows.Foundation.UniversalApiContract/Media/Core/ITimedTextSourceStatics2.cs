// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.ITimedTextSourceStatics2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Media.Core
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(3060495874, 37438, 17402, 150, 51, 88, 112, 117, 129, 45, 181)]
  [ExclusiveTo(typeof (TimedTextSource))]
  internal interface ITimedTextSourceStatics2
  {
    [Overload("CreateFromStreamWithIndex")]
    TimedTextSource CreateFromStreamWithIndex(
      IRandomAccessStream stream,
      IRandomAccessStream indexStream);

    [Overload("CreateFromUriWithIndex")]
    TimedTextSource CreateFromUriWithIndex(Uri uri, Uri indexUri);

    [Overload("CreateFromStreamWithIndexAndLanguage")]
    TimedTextSource CreateFromStreamWithIndex(
      IRandomAccessStream stream,
      IRandomAccessStream indexStream,
      string defaultLanguage);

    [Overload("CreateFromUriWithIndexAndLanguage")]
    TimedTextSource CreateFromUriWithIndex(
      Uri uri,
      Uri indexUri,
      string defaultLanguage);
  }
}
