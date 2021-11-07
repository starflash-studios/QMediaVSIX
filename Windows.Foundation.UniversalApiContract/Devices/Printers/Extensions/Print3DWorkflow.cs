// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Printers.Extensions.Print3DWorkflow
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Printers.Extensions
{
  /// <summary>Represents a customized printing experience for a 3D printer.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  public sealed class Print3DWorkflow : IPrint3DWorkflow, IPrint3DWorkflow2
  {
    /// <summary>Gets the device identifier of the 3D printer.</summary>
    /// <returns>The device identifier of the 3D printer.</returns>
    public extern string DeviceID { [MethodImpl] get; }

    /// <summary>Gets the model of the 3D object to be printed.</summary>
    /// <returns>The model of the 3D object to be printed.</returns>
    [MethodImpl]
    public extern object GetPrintModelPackage();

    /// <summary>Gets or sets a value that indicates the 3D object is ready for printing and no further user interaction is required.</summary>
    /// <returns>**true** if the 3D object is ready for printing; otherwise, **false**.</returns>
    public extern bool IsPrintReady { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Occurs when the user initiates printing.</summary>
    public extern event TypedEventHandler<Print3DWorkflow, Print3DWorkflowPrintRequestedEventArgs> PrintRequested;

    /// <summary>Occurs when the user changes the designated 3D printer.</summary>
    public extern event TypedEventHandler<Print3DWorkflow, Print3DWorkflowPrinterChangedEventArgs> PrinterChanged;
  }
}
