// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Connectivity.ICellularApnContext2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Connectivity
{
  [ExclusiveTo(typeof (CellularApnContext))]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [Guid(1991306010, 44105, 17232, 177, 229, 220, 71, 99, 188, 105, 199)]
  internal interface ICellularApnContext2
  {
    string ProfileName { get; set; }
  }
}
