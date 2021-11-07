// Decompiled with JetBrains decompiler
// Type: Windows.UI.Core.CoreDispatcherPriority
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Core
{
  /// <summary>Defines the priority for window event dispatches.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  public enum CoreDispatcherPriority
  {
    /// <summary>Lowest priority. Use this priority for background tasks. Delegates are processed when the window's main thread is idle and there is no input pending in the queue.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] Idle = -2, // 0xFFFFFFFE
    /// <summary>Low priority. Delegates are processed if there are no higher priority events pending in the queue.</summary>
    Low = -1, // 0xFFFFFFFF
    /// <summary>Normal priority. Delegates are processed in the order they are scheduled.</summary>
    Normal = 0,
    /// <summary>High priority. Delegates are invoked immediately for all synchronous requests. Asynchronous requests are queued and processed before any other request type.</summary>
    High = 1,
  }
}
