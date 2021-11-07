// Decompiled with JetBrains decompiler
// Type: Windows.Storage.Pickers.IFolderPicker
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Storage.Pickers
{
  [ExclusiveTo(typeof (FolderPicker))]
  [Guid(139425689, 62459, 16394, 153, 177, 123, 74, 119, 47, 214, 13)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IFolderPicker
  {
    PickerViewMode ViewMode { get; set; }

    string SettingsIdentifier { get; set; }

    PickerLocationId SuggestedStartLocation { get; set; }

    string CommitButtonText { get; set; }

    IVector<string> FileTypeFilter { get; }

    IAsyncOperation<StorageFolder> PickSingleFolderAsync();
  }
}
