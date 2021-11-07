// Decompiled with JetBrains decompiler
// Type: Windows.System.IAppMemoryReport2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System
{
  [Guid(1602172728, 20919, 17116, 183, 237, 121, 186, 70, 210, 136, 87)]
  [ExclusiveTo(typeof (AppMemoryReport))]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  internal interface IAppMemoryReport2
  {
    ulong ExpectedTotalCommitLimit { get; }
  }
}
