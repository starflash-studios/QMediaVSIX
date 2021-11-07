// Decompiled with JetBrains decompiler
// Type: Windows.Media.ContentRestrictions.IRatedContentDescription
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Media.ContentRestrictions
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (RatedContentDescription))]
  [Guid(1766352607, 26290, 19907, 150, 177, 240, 144, 238, 222, 226, 85)]
  internal interface IRatedContentDescription
  {
    string Id { get; set; }

    string Title { get; set; }

    IRandomAccessStreamReference Image { get; set; }

    RatedContentCategory Category { get; set; }

    IVector<string> Ratings { get; set; }
  }
}
