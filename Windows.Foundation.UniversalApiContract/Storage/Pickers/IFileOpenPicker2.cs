// Decompiled with JetBrains decompiler
// Type: Windows.Storage.Pickers.IFileOpenPicker2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Storage.Pickers
{
  [ExclusiveTo(typeof (FileOpenPicker))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2364239058, 46150, 18167, 178, 101, 144, 248, 229, 90, 214, 80)]
  internal interface IFileOpenPicker2
  {
    ValueSet ContinuationData { [Deprecated("Instead, use PickSingleFileAsync/PickMultipleFilesAsync", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] get; }

    [Deprecated("Instead, use PickSingleFileAsync", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")]
    void PickSingleFileAndContinue();

    [Deprecated("Instead, use PickMultipleFilesAsync", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")]
    void PickMultipleFilesAndContinue();
  }
}
