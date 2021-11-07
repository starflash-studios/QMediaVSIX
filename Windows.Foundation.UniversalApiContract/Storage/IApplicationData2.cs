// Decompiled with JetBrains decompiler
// Type: Windows.Storage.IApplicationData2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Storage
{
  [Guid(2657471849, 2979, 20018, 190, 41, 176, 45, 230, 96, 118, 56)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (ApplicationData))]
  internal interface IApplicationData2
  {
    StorageFolder LocalCacheFolder { get; }
  }
}
