// Decompiled with JetBrains decompiler
// Type: Windows.UI.Core.Preview.SystemNavigationManagerPreview
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Core.Preview
{
  /// <summary>Provides a way for an app to respond to system provided close events.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (ISystemNavigationManagerPreviewStatics), 262144, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  public sealed class SystemNavigationManagerPreview : ISystemNavigationManagerPreview
  {
    /// <summary>Occurs when the user invokes the system button for close (the 'x' button in the corner of the app's title bar).</summary>
    public extern event EventHandler<SystemNavigationCloseRequestedPreviewEventArgs> CloseRequested;

    /// <summary>Returns the SystemNavigationManagerPreview object associated with the current window.</summary>
    /// <returns>The SystemNavigationManagerPreview object associated with the current window.</returns>
    [MethodImpl]
    public static extern SystemNavigationManagerPreview GetForCurrentView();
  }
}
