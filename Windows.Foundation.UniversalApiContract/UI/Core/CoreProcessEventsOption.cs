// Decompiled with JetBrains decompiler
// Type: Windows.UI.Core.CoreProcessEventsOption
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Core
{
  /// <summary>Specifies the set of exclusive event-processing options passed to ProcessEvents.</summary>
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum CoreProcessEventsOption
  {
    /// <summary>Dispatch all currently available events in the queue. If no events are pending, wait for the next new event.</summary>
    ProcessOneAndAllPending,
    /// <summary>Dispatch one event if it is currently pending in the queue. If no events are pending, do not wait for a new event to be raised but instead return immediately.</summary>
    ProcessOneIfPresent,
    /// <summary>Wait for new events and dispatch all available events. Continue this behavior until the window is closed or the application calls the Close method on the CoreWindow instance.</summary>
    ProcessUntilQuit,
    /// <summary>Dispatch all events currently pending in the queue. If no events are pending, do not wait for a new event to be raised but instead return immediately. This option is provided specifically for view provider implementations with IFrameworkView, and to be used in UWP app using DirectX with C++.</summary>
    ProcessAllIfPresent,
  }
}
