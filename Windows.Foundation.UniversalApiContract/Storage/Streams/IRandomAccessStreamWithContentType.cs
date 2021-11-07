// Decompiled with JetBrains decompiler
// Type: Windows.Storage.Streams.IRandomAccessStreamWithContentType
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Storage.Streams
{
  /// <summary>Supports random access of data in input and output streams for a specified data format.</summary>
  [Guid(3424995367, 19261, 17295, 146, 50, 16, 199, 107, 199, 224, 56)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public interface IRandomAccessStreamWithContentType : 
    IRandomAccessStream,
    IClosable,
    IInputStream,
    IOutputStream,
    IContentTypeProvider
  {
  }
}
