// Decompiled with JetBrains decompiler
// Type: Windows.Storage.ISystemDataPathsStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Storage
{
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [ExclusiveTo(typeof (SystemDataPaths))]
  [Guid(3774443472, 39200, 19402, 179, 121, 249, 111, 223, 124, 170, 216)]
  internal interface ISystemDataPathsStatics
  {
    SystemDataPaths GetDefault();
  }
}
