// Decompiled with JetBrains decompiler
// Type: Windows.Storage.Pickers.Provider.IFileSavePickerUI
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Storage.Pickers.Provider
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2522268135, 15958, 17356, 138, 57, 51, 199, 61, 157, 84, 43)]
  [ExclusiveTo(typeof (FileSavePickerUI))]
  internal interface IFileSavePickerUI
  {
    string Title { get; set; }

    IVectorView<string> AllowedFileTypes { get; }

    string SettingsIdentifier { get; }

    string FileName { get; }

    SetFileNameResult TrySetFileName(string value);

    event TypedEventHandler<FileSavePickerUI, object> FileNameChanged;

    event TypedEventHandler<FileSavePickerUI, TargetFileRequestedEventArgs> TargetFileRequested;
  }
}
