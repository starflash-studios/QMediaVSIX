// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Lights.ILampAvailabilityChangedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Lights
{
  [Guid(1332624877, 1954, 18845, 146, 96, 103, 227, 4, 83, 43, 164)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (LampAvailabilityChangedEventArgs))]
  internal interface ILampAvailabilityChangedEventArgs
  {
    bool IsAvailable { get; }
  }
}
