// Decompiled with JetBrains decompiler
// Type: Windows.UI.Core.SystemNavigationManager
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Core
{
  /// <summary>Provides a way for an app to respond to system provided back-navigation events.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (ISystemNavigationManagerStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class SystemNavigationManager : ISystemNavigationManager, ISystemNavigationManager2
  {
    /// <summary>Occurs when the user invokes the system provided button, gesture, or voice command for back-navigation.</summary>
    public extern event EventHandler<BackRequestedEventArgs> BackRequested;

    /// <summary>Gets or sets a value that indicates whether a back button is shown in the system UI.</summary>
    /// <returns>One of the enumeration values that specifies whether a back button is shown in the system UI. The default is **Collapsed**.</returns>
    public extern AppViewBackButtonVisibility AppViewBackButtonVisibility { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Returns the SystemNavigationManager object associated with the current window.</summary>
    /// <returns>The SystemNavigationManager object associated with the current window.</returns>
    [MethodImpl]
    public static extern SystemNavigationManager GetForCurrentView();
  }
}
