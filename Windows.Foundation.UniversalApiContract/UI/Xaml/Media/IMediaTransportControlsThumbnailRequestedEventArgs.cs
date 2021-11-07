// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.IMediaTransportControlsThumbnailRequestedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.UI.Xaml.Media
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [WebHostHidden]
  [Guid(3836260892, 58306, 18524, 174, 105, 241, 83, 123, 118, 117, 90)]
  [ExclusiveTo(typeof (MediaTransportControlsThumbnailRequestedEventArgs))]
  internal interface IMediaTransportControlsThumbnailRequestedEventArgs
  {
    void SetThumbnailImage(IInputStream source);

    Deferral GetDeferral();
  }
}
