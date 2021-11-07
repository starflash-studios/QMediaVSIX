// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Printers.Extensions.Print3DWorkflowPrinterChangedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Printers.Extensions
{
  /// <summary>Provides data about the printer change to the app that initiated the change.</summary>
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class Print3DWorkflowPrinterChangedEventArgs : 
    IPrint3DWorkflowPrinterChangedEventArgs
  {
    /// <summary>Gets the device identifier of the new 3D printer.</summary>
    /// <returns>Device identifier of the new 3D printer.</returns>
    public extern string NewDeviceId { [MethodImpl] get; }
  }
}
