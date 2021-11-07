// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Printers.Extensions.Print3DWorkflowPrintRequestedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Printers.Extensions
{
  /// <summary>Provides data about the print request to the app that initiated the request.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  public sealed class Print3DWorkflowPrintRequestedEventArgs : 
    IPrint3DWorkflowPrintRequestedEventArgs
  {
    /// <summary>Gets the status of the print request.</summary>
    /// <returns>The status of the print request.</returns>
    public extern Print3DWorkflowStatus Status { [MethodImpl] get; }

    /// <summary>Sets the extended status of the print request.</summary>
    /// <param name="value">The extended status of the print request.</param>
    [MethodImpl]
    public extern void SetExtendedStatus(Print3DWorkflowDetail value);

    /// <summary>Sets the latest model data, including any updates made by the Print3DWorkflow.</summary>
    /// <param name="source">The latest model data, including any updates made by the Print3DWorkflow.</param>
    [MethodImpl]
    public extern void SetSource(object source);

    /// <summary>Indicates if the data model has been updated by the Print3DWorkflow.</summary>
    /// <param name="value">Returns **true** if the data model has been updated; otherwise, **false**.</param>
    [MethodImpl]
    public extern void SetSourceChanged(bool value);
  }
}
