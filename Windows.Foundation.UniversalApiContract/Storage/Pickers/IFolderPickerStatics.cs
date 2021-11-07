// Decompiled with JetBrains decompiler
// Type: Windows.Storage.Pickers.IFolderPickerStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.System;

namespace Windows.Storage.Pickers
{
  [Guid(2615363392, 31905, 22850, 163, 200, 70, 242, 85, 30, 207, 243)]
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  [ExclusiveTo(typeof (FolderPicker))]
  internal interface IFolderPickerStatics
  {
    FolderPicker CreateForUser(User user);
  }
}
