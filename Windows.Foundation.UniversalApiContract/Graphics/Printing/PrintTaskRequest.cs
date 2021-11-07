// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Printing.PrintTaskRequest
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Printing
{
  /// <summary>Contains the request from the system to create a print task. This object is available from the PrintTaskRequestedEventArgs object passed to the PrintTaskRequested event.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [Muse(Version = 100794368)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class PrintTaskRequest : IPrintTaskRequest
  {
    /// <summary>Gets a DateTime value that indicates how long an app has to respond to the PrintTaskRequested event. If the system has not received a response from the PrintTaskRequested event handler by the time the deadline is reached, then the print task is ignored.</summary>
    /// <returns>A value that indicates how long an app has to respond to the PrintTaskRequested event.</returns>
    public extern DateTime Deadline { [MethodImpl] get; }

    /// <summary>Creates a new PrintTask which indicates that the app has content to be printed.</summary>
    /// <param name="title">Title for the print task.</param>
    /// <param name="handler">Pointer to a **PrintTaskSourceRequestedHandler** delegate for the print task.</param>
    /// <returns>Pointer to the print task that was created.</returns>
    [MethodImpl]
    public extern PrintTask CreatePrintTask(
      string title,
      PrintTaskSourceRequestedHandler handler);

    /// <summary>Retrieves the deferral object associated with the PrintTaskRequest. The deferral object is used to handle asynchronous calls in the PrintTaskRequested event handler.</summary>
    /// <returns>The **PrintTaskRequestedDeferral** for a print task.</returns>
    [MethodImpl]
    public extern PrintTaskRequestedDeferral GetDeferral();
  }
}
