// Decompiled with JetBrains decompiler
// Type: Windows.UI.Core.Preview.SystemNavigationCloseRequestedPreviewEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Core.Preview
{
  /// <summary>Provides event data for the SystemNavigationManagerPreview.CloseRequested event.</summary>
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class SystemNavigationCloseRequestedPreviewEventArgs : 
    ISystemNavigationCloseRequestedPreviewEventArgs
  {
    /// <summary>Gets or sets a value that indicates whether the close request is handled by the app.</summary>
    /// <returns>**true** if the app has handled the close request; otherwise, **false**. The default is **false**.</returns>
    public extern bool Handled { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Returns a Deferral object for the CloseRequested event.</summary>
    /// <returns>A Deferral object for the CloseRequested event.</returns>
    [MethodImpl]
    public extern Deferral GetDeferral();
  }
}
