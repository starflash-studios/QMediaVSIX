// Decompiled with JetBrains decompiler
// Type: Windows.Networking.NetworkOperators.MobileBroadbandCellsInfo
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Networking.NetworkOperators
{
  /// <summary>Retrieves the serving and neighboring network cell information including respective signal strength and cell tower identification information.</summary>
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class MobileBroadbandCellsInfo : 
    IMobileBroadbandCellsInfo,
    IMobileBroadbandCellsInfo2
  {
    /// <summary>Gets a read-only array of neighboring [**MobileBroadbandCellCdma**](mobilebroadbandcellcdma.md containing all CDMA providers.</summary>
    /// <returns>A read-only array of neighboring [**MobileBroadbandCellCdma**](mobilebroadbandcellcdma.md containing all CDMA providers.</returns>
    public extern IVectorView<MobileBroadbandCellCdma> NeighboringCellsCdma { [MethodImpl] get; }

    /// <summary>Gets a read-only array of neighboring MobileBroadbandCellGsm containing all GSM providers.</summary>
    /// <returns>A read-only array of neighboring MobileBroadbandCellGsm containing all GSM providers.</returns>
    public extern IVectorView<MobileBroadbandCellGsm> NeighboringCellsGsm { [MethodImpl] get; }

    /// <summary>Gets a read-only array of neighboring MobileBroadbandCellLte containing all LTE providers.</summary>
    /// <returns>A read-only array of neighboring MobileBroadbandCellLte containing all LTE providers.</returns>
    public extern IVectorView<MobileBroadbandCellLte> NeighboringCellsLte { [MethodImpl] get; }

    /// <summary>Gets a read-only array of neighboring MobileBroadbandCellTdscdma containing all TDSCMA providers.</summary>
    /// <returns>A read-only array of neighboring MobileBroadbandCellTdscdma containing all TDSCMA providers.</returns>
    public extern IVectorView<MobileBroadbandCellTdscdma> NeighboringCellsTdscdma { [MethodImpl] get; }

    /// <summary>Gets a read-only array of neighboring MobileBroadbandCellUmts containing all UMTS providers.</summary>
    /// <returns>A read-only array of neighboring MobileBroadbandCellUmts containing all UMTS providers.</returns>
    public extern IVectorView<MobileBroadbandCellUmts> NeighboringCellsUmts { [MethodImpl] get; }

    /// <summary>Gets a read-only array of serving MobileBroadbandCellCdma containing all CDMA providers.</summary>
    /// <returns>A read-only array of serving MobileBroadbandCellCdma containing all CDMA providers.</returns>
    public extern IVectorView<MobileBroadbandCellCdma> ServingCellsCdma { [MethodImpl] get; }

    /// <summary>Gets a read-only array of neighboring MobileBroadbandCellGsm containing all GSM providers.</summary>
    /// <returns>A read-only array of neighboring MobileBroadbandCellGsm containing all GSM providers.</returns>
    public extern IVectorView<MobileBroadbandCellGsm> ServingCellsGsm { [MethodImpl] get; }

    /// <summary>Gets a read-only array of neighboring MobileBroadbandCellLte containing all LTE providers.</summary>
    /// <returns>A read-only array of neighboring MobileBroadbandCellLte containing all LTE providers.</returns>
    public extern IVectorView<MobileBroadbandCellLte> ServingCellsLte { [MethodImpl] get; }

    /// <summary>Gets a read-only array of serving MobileBroadbandCellTdscdma containing all TDSCMA providers.</summary>
    /// <returns>A read-only array of serving MobileBroadbandCellTdscdma containing all TDSCMA providers.</returns>
    public extern IVectorView<MobileBroadbandCellTdscdma> ServingCellsTdscdma { [MethodImpl] get; }

    /// <summary>Gets a read-only array of serving MobileBroadbandCellUmts containing all UMTS providers.</summary>
    /// <returns>A read-only array of serving MobileBroadbandCellUmts containing all UMTS providers.</returns>
    public extern IVectorView<MobileBroadbandCellUmts> ServingCellsUmts { [MethodImpl] get; }

    public extern IVectorView<MobileBroadbandCellNR> NeighboringCellsNR { [MethodImpl] get; }

    public extern IVectorView<MobileBroadbandCellNR> ServingCellsNR { [MethodImpl] get; }
  }
}
