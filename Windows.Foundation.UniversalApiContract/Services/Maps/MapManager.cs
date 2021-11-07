// Decompiled with JetBrains decompiler
// Type: Windows.Services.Maps.MapManager
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Services.Maps
{
  /// <summary>Displays the UI that lets users download maps for offline use, or update maps that were previously downloaded.</summary>
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IMapManagerStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public static class MapManager
  {
    /// <summary>Displays the UI that lets users download maps for offline use.</summary>
    [MethodImpl]
    public static extern void ShowDownloadedMapsUI();

    /// <summary>Displays the UI that lets users update maps that were previously downloaded for offline use.</summary>
    [MethodImpl]
    public static extern void ShowMapsUpdateUI();
  }
}
