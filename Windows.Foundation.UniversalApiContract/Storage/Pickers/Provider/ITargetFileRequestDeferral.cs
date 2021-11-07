// Decompiled with JetBrains decompiler
// Type: Windows.Storage.Pickers.Provider.ITargetFileRequestDeferral
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Storage.Pickers.Provider
{
  [ExclusiveTo(typeof (TargetFileRequestDeferral))]
  [Guid(1257151889, 48917, 19881, 149, 246, 246, 183, 213, 88, 34, 91)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ITargetFileRequestDeferral
  {
    void Complete();
  }
}
