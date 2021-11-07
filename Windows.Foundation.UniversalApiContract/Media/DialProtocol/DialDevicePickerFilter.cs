// Decompiled with JetBrains decompiler
// Type: Windows.Media.DialProtocol.DialDevicePickerFilter
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Media.DialProtocol
{
  /// <summary>Represents the filter used to determine which devices to show in a DialDevicePicker. The filter parameters are OR-ed together to build the resulting filter.</summary>
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 167772160)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class DialDevicePickerFilter : IDialDevicePickerFilter
  {
    /// <summary>Gets a list of DIAL apps supported by the remote devices. Defaults to an empty list (no filter). You can add one or more app names and filter the devices list to those that can launch one the supported apps.</summary>
    /// <returns>The list of supported apps.</returns>
    public extern IVector<string> SupportedAppNames { [MethodImpl] get; }
  }
}
