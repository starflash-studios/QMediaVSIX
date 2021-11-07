// Decompiled with JetBrains decompiler
// Type: Windows.Media.Capture.ICapturedFrame
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Media.Capture
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(500358687, 22299, 17624, 142, 128, 160, 138, 21, 120, 118, 110)]
  [ExclusiveTo(typeof (CapturedFrame))]
  internal interface ICapturedFrame : 
    IRandomAccessStreamWithContentType,
    IRandomAccessStream,
    IClosable,
    IInputStream,
    IOutputStream,
    IContentTypeProvider
  {
    uint Width { get; }

    uint Height { get; }
  }
}
