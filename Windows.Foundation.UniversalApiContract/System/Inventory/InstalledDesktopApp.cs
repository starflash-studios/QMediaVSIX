// Decompiled with JetBrains decompiler
// Type: Windows.System.Inventory.InstalledDesktopApp
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.System.Inventory
{
  /// <summary>Provides a list of installed Win32 apps available to the current user. This includes apps installed for all users as well as only for the current user.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [Threading(ThreadingModel.Both)]
  [Static(typeof (IInstalledDesktopAppStatics), 393216, "Windows.Foundation.UniversalApiContract")]
  public sealed class InstalledDesktopApp : IInstalledDesktopApp, IStringable
  {
    /// <summary>Gets the string-based ID of the installed desktop app.</summary>
    /// <returns>The string-based ID of the installed desktop app.</returns>
    public extern string Id { [MethodImpl] get; }

    /// <summary>Gets the display name of the installed desktop app.</summary>
    /// <returns>The display name of the installed desktop app.</returns>
    public extern string DisplayName { [MethodImpl] get; }

    /// <summary>Gets the publisher of the installed desktop app.</summary>
    /// <returns>The publisher of the installed desktop app.</returns>
    public extern string Publisher { [MethodImpl] get; }

    /// <summary>Gets the string-based version of the installed desktop app.</summary>
    /// <returns>The string-based version of the installed desktop app.</returns>
    public extern string DisplayVersion { [MethodImpl] get; }

    /// <summary>Returns a string that represents the current InstalledDesktopApp object.</summary>
    /// <returns>The string version of the InstalledDesktopApp.</returns>
    [MethodImpl]
    public new extern string ToString();

    /// <summary>Gets a list of installed Win32 apps available to the current user. This includes apps installed for all users as well as only for the current user.</summary>
    /// <returns>Returns an async operation indicating that the task has completed and containing a list of installed Win32 apps available to the current user.</returns>
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<IVectorView<InstalledDesktopApp>> GetInventoryAsync();
  }
}
