// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Haptics.IVibrationDevice
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Haptics
{
  [Guid(1089608254, 34884, 18431, 179, 18, 6, 24, 90, 56, 68, 218)]
  [ExclusiveTo(typeof (VibrationDevice))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  internal interface IVibrationDevice
  {
    string Id { get; }

    SimpleHapticsController SimpleHapticsController { get; }
  }
}
