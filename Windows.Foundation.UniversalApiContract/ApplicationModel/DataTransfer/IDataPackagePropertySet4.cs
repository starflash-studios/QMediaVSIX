// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.DataTransfer.IDataPackagePropertySet4
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.DataTransfer
{
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [Guid(1670441973, 5945, 19572, 178, 47, 134, 95, 171, 94, 133, 69)]
  [ExclusiveTo(typeof (DataPackagePropertySet))]
  internal interface IDataPackagePropertySet4
  {
    string ContentSourceUserActivityJson { get; set; }
  }
}
