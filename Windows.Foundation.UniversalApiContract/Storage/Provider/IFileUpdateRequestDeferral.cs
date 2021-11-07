// Decompiled with JetBrains decompiler
// Type: Windows.Storage.Provider.IFileUpdateRequestDeferral
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Storage.Provider
{
  [Guid(4291746603, 35550, 17573, 187, 0, 22, 76, 78, 114, 241, 58)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (FileUpdateRequestDeferral))]
  internal interface IFileUpdateRequestDeferral
  {
    void Complete();
  }
}
