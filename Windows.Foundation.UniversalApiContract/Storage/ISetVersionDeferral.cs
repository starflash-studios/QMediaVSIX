// Decompiled with JetBrains decompiler
// Type: Windows.Storage.ISetVersionDeferral
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Storage
{
  [ExclusiveTo(typeof (SetVersionDeferral))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(53807266, 30746, 17274, 176, 120, 63, 50, 186, 220, 254, 71)]
  internal interface ISetVersionDeferral
  {
    void Complete();
  }
}
