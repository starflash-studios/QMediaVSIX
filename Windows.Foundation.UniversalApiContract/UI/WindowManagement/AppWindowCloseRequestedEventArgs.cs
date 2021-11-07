// Decompiled with JetBrains decompiler
// Type: Windows.UI.WindowManagement.AppWindowCloseRequestedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.WindowManagement
{
  /// <summary>Provides data for the AppWindow.CloseRequested event.</summary>
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [WebHostHidden]
  public sealed class AppWindowCloseRequestedEventArgs : IAppWindowCloseRequestedEventArgs
  {
    /// <summary>Gets or sets a value that indicates whether the close operation should be canceled.</summary>
    /// <returns>**true** to cancel the close operation; otherwise, **false**. The default is **false**.</returns>
    public extern bool Cancel { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets a deferral object for managing asynchronous work done in the CloseRequested event handler.</summary>
    /// <returns>A deferral object.</returns>
    [MethodImpl]
    public extern Deferral GetDeferral();
  }
}
