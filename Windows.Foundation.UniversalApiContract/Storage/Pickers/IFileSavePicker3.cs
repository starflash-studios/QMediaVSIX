// Decompiled with JetBrains decompiler
// Type: Windows.Storage.Pickers.IFileSavePicker3
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Storage.Pickers
{
  [ExclusiveTo(typeof (FileSavePicker))]
  [Guid(1770712169, 47676, 20049, 189, 144, 74, 188, 187, 244, 207, 175)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IFileSavePicker3
  {
    string EnterpriseId { get; set; }
  }
}
