// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Connectivity.IDataPlanUsage
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Connectivity
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3105966381, 15172, 18431, 179, 97, 190, 89, 230, 158, 209, 176)]
  [ExclusiveTo(typeof (DataPlanUsage))]
  internal interface IDataPlanUsage
  {
    uint MegabytesUsed { get; }

    DateTime LastSyncTime { get; }
  }
}
