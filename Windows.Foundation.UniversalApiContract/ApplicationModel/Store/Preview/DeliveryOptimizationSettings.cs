// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Store.Preview.DeliveryOptimizationSettings
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Store.Preview
{
  /// <summary>Provides access to the Delivery Optimization settings for the current device.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [Threading(ThreadingModel.Both)]
  [Static(typeof (IDeliveryOptimizationSettingsStatics), 458752, "Windows.Foundation.UniversalApiContract")]
  public sealed class DeliveryOptimizationSettings : IDeliveryOptimizationSettings
  {
    /// <summary>Gets the current download mode type in the Delivery Optimization settings for the current device.</summary>
    /// <returns>The current download mode type in the Delivery Optimization settings for the current device.</returns>
    public extern DeliveryOptimizationDownloadMode DownloadMode { [MethodImpl] get; }

    /// <summary>Gets the source of the current download mode in the Delivery Optimization settings for the current device.</summary>
    /// <returns>The source of the current download mode in the Delivery Optimization settings for the current device.</returns>
    public extern DeliveryOptimizationDownloadModeSource DownloadModeSource { [MethodImpl] get; }

    /// <summary>Gets the Delivery Optimization settings for the current device.</summary>
    /// <returns>An object that provides the Delivery Optimization settings for the current device.</returns>
    [MethodImpl]
    public static extern DeliveryOptimizationSettings GetCurrentSettings();
  }
}
