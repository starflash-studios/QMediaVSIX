// Decompiled with JetBrains decompiler
// Type: Windows.System.IAppMemoryUsageLimitChangingEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System
{
  [ExclusiveTo(typeof (AppMemoryUsageLimitChangingEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2046322276, 65226, 19877, 158, 64, 43, 198, 62, 253, 201, 121)]
  internal interface IAppMemoryUsageLimitChangingEventArgs
  {
    ulong OldLimit { get; }

    ulong NewLimit { get; }
  }
}
