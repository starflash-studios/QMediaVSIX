// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Printing.PrintManager
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Printing
{
  /// <summary>Informs Windows that an application wishes to participate in printing. The PrintManager class is also used for programmatically initiating printing.</summary>
  [Static(typeof (IPrintManagerStatic), 65536, "Windows.Foundation.UniversalApiContract")]
  [Muse(Version = 100794368)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (IPrintManagerStatic2), 196608, "Windows.Foundation.UniversalApiContract")]
  public sealed class PrintManager : IPrintManager
  {
    /// <summary>Raised when a request to print has occurred. This event may be triggered by user action or via programmatic invocation of printing via the ShowPrintUIAsync method.</summary>
    public extern event TypedEventHandler<PrintManager, PrintTaskRequestedEventArgs> PrintTaskRequested;

    /// <summary>Indicates whether or not the app is running on a device that supports printing.</summary>
    /// <returns>Returns **true** if on a device that supports printing, returns **false** if not.</returns>
    [MethodImpl]
    public static extern bool IsSupported();

    /// <summary>Retrieves the **PrintManager** object associated with the current window.</summary>
    /// <returns>The **PrintManager** object.</returns>
    [MethodImpl]
    public static extern PrintManager GetForCurrentView();

    /// <summary>Programmatically initiates the user interface for printing content.</summary>
    /// <returns>A Boolean value to indicate a TRUE for success or a FALSE for a failure.</returns>
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<bool> ShowPrintUIAsync();
  }
}
