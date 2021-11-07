// Decompiled with JetBrains decompiler
// Type: Windows.Storage.Pickers.IFolderPicker3
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.System;

namespace Windows.Storage.Pickers
{
  [ExclusiveTo(typeof (FolderPicker))]
  [Guid(1731927593, 54054, 21440, 189, 36, 162, 92, 113, 76, 238, 54)]
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  internal interface IFolderPicker3
  {
    User User { get; }
  }
}
