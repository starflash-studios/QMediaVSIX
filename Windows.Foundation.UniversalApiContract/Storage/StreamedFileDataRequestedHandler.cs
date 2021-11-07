// Decompiled with JetBrains decompiler
// Type: Windows.Storage.StreamedFileDataRequestedHandler
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Storage
{
  /// <summary>Represents the method that will stream data into a StorageFile when that file is first accessed.</summary>
  /// <param name="stream">The request for the streamed data in the StorageFile that was created by the CreateStreamedFileAsync or ReplaceWithStreamedFileAsync method.</param>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(4277577764, 12257, 19719, 163, 91, 183, 124, 80, 181, 244, 204)]
  public delegate void StreamedFileDataRequestedHandler(StreamedFileDataRequest stream);
}
