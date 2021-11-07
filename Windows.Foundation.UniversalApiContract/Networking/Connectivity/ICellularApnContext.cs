// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Connectivity.ICellularApnContext
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Connectivity
{
  [ExclusiveTo(typeof (CellularApnContext))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1873095156, 61437, 17730, 154, 178, 112, 91, 191, 148, 148, 58)]
  internal interface ICellularApnContext
  {
    string ProviderId { get; set; }

    string AccessPointName { get; set; }

    string UserName { get; set; }

    string Password { get; set; }

    bool IsCompressionEnabled { get; set; }

    CellularApnAuthenticationType AuthenticationType { get; set; }
  }
}
