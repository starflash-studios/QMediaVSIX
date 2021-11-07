// Decompiled with JetBrains decompiler
// Type: Windows.Storage.Pickers.Provider.IFileOpenPickerUI
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Storage.Pickers.Provider
{
  [ExclusiveTo(typeof (FileOpenPickerUI))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3718535696, 63956, 16580, 138, 245, 197, 182, 181, 166, 29, 29)]
  internal interface IFileOpenPickerUI
  {
    AddFileResult AddFile(string id, IStorageFile file);

    void RemoveFile(string id);

    bool ContainsFile(string id);

    bool CanAddFile(IStorageFile file);

    IVectorView<string> AllowedFileTypes { get; }

    FileSelectionMode SelectionMode { get; }

    string SettingsIdentifier { get; }

    string Title { get; set; }

    event TypedEventHandler<FileOpenPickerUI, FileRemovedEventArgs> FileRemoved;

    event TypedEventHandler<FileOpenPickerUI, PickerClosingEventArgs> Closing;
  }
}
