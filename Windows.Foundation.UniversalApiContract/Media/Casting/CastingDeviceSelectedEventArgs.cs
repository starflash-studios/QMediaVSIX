// Decompiled with JetBrains decompiler
// Type: Windows.Media.Casting.CastingDeviceSelectedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Casting
{
  /// <summary>Represents the event arguments for the CastingDeviceSelected event on the CastingDevicePicker object.</summary>
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 167772160)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class CastingDeviceSelectedEventArgs : ICastingDeviceSelectedEventArgs
  {
    /// <summary>Represents the CastingDevice that has been selected by the user in a casting device picker.</summary>
    /// <returns>The casting device that the user has selected.</returns>
    public extern CastingDevice SelectedCastingDevice { [MethodImpl] get; }
  }
}
