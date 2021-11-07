// Decompiled with JetBrains decompiler
// Type: Windows.Storage.Pickers.IFileOpenPicker
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Storage.Pickers
{
  [Guid(749217674, 4805, 19551, 137, 119, 148, 84, 119, 147, 194, 65)]
  [ExclusiveTo(typeof (FileOpenPicker))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IFileOpenPicker
  {
    PickerViewMode ViewMode { get; set; }

    string SettingsIdentifier { get; set; }

    PickerLocationId SuggestedStartLocation { get; set; }

    string CommitButtonText { get; set; }

    IVector<string> FileTypeFilter { get; }

    IAsyncOperation<StorageFile> PickSingleFileAsync();

    IAsyncOperation<IVectorView<StorageFile>> PickMultipleFilesAsync();
  }
}
