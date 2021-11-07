// Decompiled with JetBrains decompiler
// Type: Windows.Storage.Streams.IInputStreamReference
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Storage.Streams
{
  /// <summary>Enables a Windows Runtime component to provide sequential read access to an encapsulated stream.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1133681944, 24265, 19290, 145, 156, 66, 5, 176, 200, 4, 182)]
  public interface IInputStreamReference
  {
    /// <summary>Opens a stream for sequential read access.</summary>
    /// <returns>The asynchronous operation.</returns>
    [RemoteAsync]
    IAsyncOperation<IInputStream> OpenSequentialReadAsync();
  }
}
