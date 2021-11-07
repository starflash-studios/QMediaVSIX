// Decompiled with JetBrains decompiler
// Type: Windows.Media.PlayTo.ISourceChangeRequestedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Media.PlayTo
{
  [Guid(4215224982, 31398, 19083, 134, 231, 84, 246, 198, 211, 79, 100)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (SourceChangeRequestedEventArgs))]
  internal interface ISourceChangeRequestedEventArgs
  {
    IRandomAccessStreamWithContentType Stream { get; }

    string Title { get; }

    string Author { get; }

    string Album { get; }

    string Genre { get; }

    string Description { get; }

    IReference<DateTime> Date { get; }

    IRandomAccessStreamReference Thumbnail { get; }

    IReference<uint> Rating { get; }

    IMapView<string, object> Properties { get; }
  }
}
