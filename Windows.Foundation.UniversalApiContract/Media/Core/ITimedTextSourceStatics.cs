// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.ITimedTextSourceStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Media.Core
{
  [ExclusiveTo(typeof (TimedTextSource))]
  [Guid(2117146707, 39610, 19140, 187, 152, 47, 177, 118, 195, 191, 221)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ITimedTextSourceStatics
  {
    [Overload("CreateFromStream")]
    TimedTextSource CreateFromStream(IRandomAccessStream stream);

    [Overload("CreateFromUri")]
    TimedTextSource CreateFromUri(Uri uri);

    [Overload("CreateFromStreamWithLanguage")]
    TimedTextSource CreateFromStream(
      IRandomAccessStream stream,
      string defaultLanguage);

    [Overload("CreateFromUriWithLanguage")]
    TimedTextSource CreateFromUri(Uri uri, string defaultLanguage);
  }
}
