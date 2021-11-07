// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Lights.LampAvailabilityChangedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Lights
{
  /// <summary>Provides data for the AvailabilityChanged event.</summary>
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class LampAvailabilityChangedEventArgs : ILampAvailabilityChangedEventArgs
  {
    /// <summary>Gets a value indicating whether the lamp device that triggered the event is available.</summary>
    /// <returns>True if the lamp device is available; otherwise, false.</returns>
    public extern bool IsAvailable { [MethodImpl] get; }
  }
}
