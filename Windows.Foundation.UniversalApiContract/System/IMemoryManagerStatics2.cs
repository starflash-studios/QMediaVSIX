// Decompiled with JetBrains decompiler
// Type: Windows.System.IMemoryManagerStatics2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1861104927, 28002, 16959, 148, 121, 176, 31, 156, 159, 118, 105)]
  [ExclusiveTo(typeof (MemoryManager))]
  internal interface IMemoryManagerStatics2
  {
    AppMemoryReport GetAppMemoryReport();

    ProcessMemoryReport GetProcessMemoryReport();
  }
}
