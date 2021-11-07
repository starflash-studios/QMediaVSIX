// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sensors.IHingeAngleSensorStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sensors
{
  [Guid(3082172688, 64433, 16675, 137, 206, 78, 163, 78, 176, 223, 202)]
  [ExclusiveTo(typeof (HingeAngleSensor))]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  internal interface IHingeAngleSensorStatics
  {
    string GetDeviceSelector();

    [RemoteAsync]
    IAsyncOperation<HingeAngleSensor> GetDefaultAsync();

    [RemoteAsync]
    IAsyncOperation<HingeAngleSensor> GetRelatedToAdjacentPanelsAsync(
      string firstPanelId,
      string secondPanelId);

    [RemoteAsync]
    IAsyncOperation<HingeAngleSensor> FromIdAsync(string deviceId);
  }
}
