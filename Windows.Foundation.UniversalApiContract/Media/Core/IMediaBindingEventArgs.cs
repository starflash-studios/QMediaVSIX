// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.IMediaBindingEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Media.Core
{
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [ExclusiveTo(typeof (MediaBindingEventArgs))]
  [Guid(3055333978, 7021, 17968, 168, 109, 47, 8, 55, 247, 18, 229)]
  internal interface IMediaBindingEventArgs
  {
    event TypedEventHandler<MediaBindingEventArgs, object> Canceled;

    MediaBinder MediaBinder { get; }

    Deferral GetDeferral();

    void SetUri(Uri uri);

    void SetStream(IRandomAccessStream stream, string contentType);

    void SetStreamReference(IRandomAccessStreamReference stream, string contentType);
  }
}
