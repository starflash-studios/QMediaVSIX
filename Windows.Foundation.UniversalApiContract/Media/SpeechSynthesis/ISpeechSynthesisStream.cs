// Decompiled with JetBrains decompiler
// Type: Windows.Media.SpeechSynthesis.ISpeechSynthesisStream
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Media.SpeechSynthesis
{
  [Guid(2212785811, 9292, 17954, 186, 11, 98, 41, 196, 208, 214, 93)]
  [ExclusiveTo(typeof (SpeechSynthesisStream))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ISpeechSynthesisStream : 
    IRandomAccessStreamWithContentType,
    IRandomAccessStream,
    IClosable,
    IInputStream,
    IOutputStream,
    IContentTypeProvider
  {
    IVectorView<IMediaMarker> Markers { get; }
  }
}
