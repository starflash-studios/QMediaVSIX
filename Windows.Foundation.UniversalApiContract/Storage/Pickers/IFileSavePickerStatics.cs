// Decompiled with JetBrains decompiler
// Type: Windows.Storage.Pickers.IFileSavePickerStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.System;

namespace Windows.Storage.Pickers
{
  [ExclusiveTo(typeof (FileSavePicker))]
  [Guid(686018462, 38428, 24108, 174, 215, 230, 71, 55, 244, 206, 55)]
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  internal interface IFileSavePickerStatics
  {
    FileSavePicker CreateForUser(User user);
  }
}
