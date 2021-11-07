// Decompiled with JetBrains decompiler
// Type: Windows.Storage.Pickers.IFileSavePicker2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Storage.Pickers
{
  [Guid(247665570, 53835, 17562, 129, 151, 232, 145, 4, 253, 66, 204)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (FileSavePicker))]
  internal interface IFileSavePicker2
  {
    ValueSet ContinuationData { get; }

    [Deprecated("Instead, use PickSaveFileAsync", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")]
    void PickSaveFileAndContinue();
  }
}
