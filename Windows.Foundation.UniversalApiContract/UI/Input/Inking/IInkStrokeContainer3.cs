// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Inking.IInkStrokeContainer3
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.UI.Input.Inking
{
  [Guid(1023917733, 47850, 19586, 167, 25, 123, 131, 218, 16, 103, 210)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [ExclusiveTo(typeof (InkStrokeContainer))]
  internal interface IInkStrokeContainer3
  {
    [Overload("SaveWithFormatAsync")]
    [RemoteAsync]
    IAsyncOperationWithProgress<uint, uint> SaveAsync(
      IOutputStream outputStream,
      InkPersistenceFormat inkPersistenceFormat);

    InkStroke GetStrokeById(uint id);
  }
}
