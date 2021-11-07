// Decompiled with JetBrains decompiler
// Type: Windows.Storage.Pickers.IFileSavePicker
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Storage.Pickers
{
  [ExclusiveTo(typeof (FileSavePicker))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(847708107, 24959, 19653, 175, 106, 179, 253, 242, 154, 209, 69)]
  internal interface IFileSavePicker
  {
    string SettingsIdentifier { get; set; }

    PickerLocationId SuggestedStartLocation { get; set; }

    string CommitButtonText { get; set; }

    IMap<string, IVector<string>> FileTypeChoices { get; }

    string DefaultFileExtension { get; set; }

    StorageFile SuggestedSaveFile { get; set; }

    string SuggestedFileName { get; set; }

    IAsyncOperation<StorageFile> PickSaveFileAsync();
  }
}
