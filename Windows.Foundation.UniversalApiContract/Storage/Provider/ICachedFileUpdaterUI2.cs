// Decompiled with JetBrains decompiler
// Type: Windows.Storage.Provider.ICachedFileUpdaterUI2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Storage.Provider
{
  [Guid(2287378972, 34457, 17216, 159, 73, 247, 202, 215, 254, 137, 145)]
  [ExclusiveTo(typeof (CachedFileUpdaterUI))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ICachedFileUpdaterUI2 : ICachedFileUpdaterUI
  {
    FileUpdateRequest UpdateRequest { get; }

    FileUpdateRequestDeferral GetDeferral();
  }
}
