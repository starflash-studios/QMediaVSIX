﻿// Decompiled with JetBrains decompiler
// Type: Windows.Storage.Pickers.IFolderPicker2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Storage.Pickers
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2394143383, 56453, 17942, 190, 148, 150, 96, 136, 31, 47, 93)]
  [ExclusiveTo(typeof (FolderPicker))]
  internal interface IFolderPicker2
  {
    ValueSet ContinuationData { get; }

    [Deprecated("Instead, use PickSingleFolderAsync", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")]
    void PickFolderAndContinue();
  }
}