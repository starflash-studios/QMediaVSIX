// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.DataTransfer.IDataPackagePropertySetView4
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.DataTransfer
{
  [ExclusiveTo(typeof (DataPackagePropertySetView))]
  [Guid(1148504077, 53615, 16558, 149, 128, 111, 133, 98, 185, 66, 53)]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  internal interface IDataPackagePropertySetView4
  {
    string ContentSourceUserActivityJson { get; }
  }
}
