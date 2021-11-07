// Decompiled with JetBrains decompiler
// Type: Windows.Storage.Pickers.IFileOpenPickerWithOperationId
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Storage.Pickers
{
  [Guid(1062712681, 9506, 19621, 170, 115, 161, 85, 9, 241, 252, 191)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (FileOpenPicker))]
  internal interface IFileOpenPickerWithOperationId
  {
    [RemoteAsync]
    IAsyncOperation<StorageFile> PickSingleFileAsync(
      string pickerOperationId);
  }
}
