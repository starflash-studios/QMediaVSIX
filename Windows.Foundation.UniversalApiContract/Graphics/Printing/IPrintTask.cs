// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Printing.IPrintTask
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.ApplicationModel.DataTransfer;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Printing
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (PrintTask))]
  [Guid(1641546311, 27894, 20397, 132, 226, 165, 232, 46, 45, 76, 235)]
  internal interface IPrintTask
  {
    DataPackagePropertySet Properties { get; }

    IPrintDocumentSource Source { get; }

    PrintTaskOptions Options { get; }

    event TypedEventHandler<PrintTask, object> Previewing;

    event TypedEventHandler<PrintTask, object> Submitting;

    event TypedEventHandler<PrintTask, PrintTaskProgressingEventArgs> Progressing;

    event TypedEventHandler<PrintTask, PrintTaskCompletedEventArgs> Completed;
  }
}
