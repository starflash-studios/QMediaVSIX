// Decompiled with JetBrains decompiler
// Type: Windows.System.IMemoryManagerStatics4
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System
{
  [Guid(3316205608, 59470, 18566, 138, 13, 68, 179, 25, 14, 59, 114)]
  [ExclusiveTo(typeof (MemoryManager))]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  internal interface IMemoryManagerStatics4
  {
    ulong ExpectedAppMemoryUsageLimit { get; }
  }
}
