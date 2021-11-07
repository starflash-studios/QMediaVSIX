// Decompiled with JetBrains decompiler
// Type: Windows.Storage.IStorageProvider
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Storage
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (StorageProvider))]
  [Guid(3875925716, 54392, 18390, 186, 70, 26, 142, 190, 17, 74, 32)]
  internal interface IStorageProvider
  {
    string Id { get; }

    string DisplayName { get; }
  }
}
