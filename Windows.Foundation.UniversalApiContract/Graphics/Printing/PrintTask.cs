// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Printing.PrintTask
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.ApplicationModel.DataTransfer;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Printing
{
  /// <summary>Represents a printing operation including the content to be printed, as well as providing access to information describing how the content is to be printed.</summary>
  [Muse(Version = 100794368)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class PrintTask : IPrintTask, IPrintTaskTargetDeviceSupport, IPrintTask2
  {
    /// <summary>Retrieves a set of properties associated with the PrintTask.</summary>
    /// <returns>The data package property set.</returns>
    public extern DataPackagePropertySet Properties { [MethodImpl] get; }

    /// <summary>Returns a pointer to the app-provided object that represents the content to be printed. This object must support the IPrintDocumentSource interface.</summary>
    /// <returns>The print task object.</returns>
    public extern IPrintDocumentSource Source { [MethodImpl] get; }

    /// <summary>Retrieves the PrintTaskOptions for the print task that defines how the content is to be formatted for printing.</summary>
    /// <returns>The list of print task options.</returns>
    public extern PrintTaskOptions Options { [MethodImpl] get; }

    /// <summary>Raised when the print system initializes print preview mode.</summary>
    public extern event TypedEventHandler<PrintTask, object> Previewing;

    /// <summary>Raised when a print task begins submitting content to the print subsystem to be printed.</summary>
    public extern event TypedEventHandler<PrintTask, object> Submitting;

    /// <summary>Raised to provide progress information about how much of the printed content has been submitted to the print subsystem for printing.</summary>
    public extern event TypedEventHandler<PrintTask, PrintTaskProgressingEventArgs> Progressing;

    /// <summary>Raised when the print task is completed.</summary>
    public extern event TypedEventHandler<PrintTask, PrintTaskCompletedEventArgs> Completed;

    /// <summary>Gets or sets a value indicating whether the PrintTask supports printer targets.</summary>
    /// <returns>True if the PrintTask supports printer targets.</returns>
    public extern bool IsPrinterTargetEnabled { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets or sets a value that indicates whether the PrintTask supports 3D manufacturing devices, like a 3D printer.</summary>
    /// <returns>True, if 3D manufacturing devices are supported.</returns>
    public extern bool Is3DManufacturingTargetEnabled { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets or sets a value that indicates whether the PrintTask will show a print preview.</summary>
    /// <returns>True, if print preview is enabled.</returns>
    public extern bool IsPreviewEnabled { [MethodImpl] set; [MethodImpl] get; }
  }
}
