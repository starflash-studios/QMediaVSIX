// Decompiled with JetBrains decompiler
// Type: Windows.UI.WebUI.SuspendingOperation
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.ApplicationModel;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.WebUI
{
  /// <summary>Manages an app suspension operation.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Standard)]
  public sealed class SuspendingOperation : ISuspendingOperation
  {
    /// <summary>Requests that the app suspension operation be delayed.</summary>
    /// <returns>The suspension deferral.</returns>
    [MethodImpl]
    public extern global::Windows.ApplicationModel.SuspendingDeferral GetDeferral();

    /// <summary>Gets the time remaining before a delayed app suspension operation continues.</summary>
    /// <returns>The time remaining.</returns>
    public extern DateTime Deadline { [MethodImpl] get; }
  }
}
