// Decompiled with JetBrains decompiler
// Type: Windows.Networking.NetworkOperators.IMobileBroadbandSarManager
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Networking.NetworkOperators
{
  [Guid(3853674547, 38526, 16585, 164, 133, 25, 192, 221, 32, 158, 34)]
  [ExclusiveTo(typeof (MobileBroadbandSarManager))]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  internal interface IMobileBroadbandSarManager
  {
    bool IsBackoffEnabled { get; }

    bool IsWiFiHardwareIntegrated { get; }

    bool IsSarControlledByHardware { get; }

    IVectorView<MobileBroadbandAntennaSar> Antennas { get; }

    TimeSpan HysteresisTimerPeriod { get; }

    event TypedEventHandler<MobileBroadbandSarManager, MobileBroadbandTransmissionStateChangedEventArgs> TransmissionStateChanged;

    [RemoteAsync]
    IAsyncAction EnableBackoffAsync();

    [RemoteAsync]
    IAsyncAction DisableBackoffAsync();

    [RemoteAsync]
    IAsyncAction SetConfigurationAsync(IIterable<MobileBroadbandAntennaSar> antennas);

    [RemoteAsync]
    IAsyncAction RevertSarToHardwareControlAsync();

    [RemoteAsync]
    IAsyncAction SetTransmissionStateChangedHysteresisAsync(TimeSpan timerPeriod);

    [RemoteAsync]
    IAsyncOperation<bool> GetIsTransmittingAsync();

    void StartTransmissionStateMonitoring();

    void StopTransmissionStateMonitoring();
  }
}
