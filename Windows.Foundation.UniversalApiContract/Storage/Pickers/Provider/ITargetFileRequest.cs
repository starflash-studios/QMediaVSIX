// Decompiled with JetBrains decompiler
// Type: Windows.Storage.Pickers.Provider.ITargetFileRequest
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Storage.Pickers.Provider
{
  [Guid(1119695701, 32648, 18315, 142, 129, 105, 11, 32, 52, 6, 120)]
  [ExclusiveTo(typeof (TargetFileRequest))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ITargetFileRequest
  {
    IStorageFile TargetFile { get; set; }

    TargetFileRequestDeferral GetDeferral();
  }
}
