// Decompiled with JetBrains decompiler
// Type: Windows.UI.StartScreen.JumpList
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.StartScreen
{
  /// <summary>Provides functionality for an app's jump list. A jump list is a system-provided menu that appears when the user right-clicks a program in the taskbar or on the Start menu. It is used to provide quick access to recently or frequently-used documents and offer direct links to app functionality. Not all device families support jump lists.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [Static(typeof (IJumpListStatics), 131072, "Windows.Foundation.UniversalApiContract")]
  public sealed class JumpList : IJumpList
  {
    /// <summary>Gets the list of JumpListItem 's for the jump list.Items is of type IVector(JumpListItem).</summary>
    /// <returns>The list of JumpListItem 's for the jump list.</returns>
    public extern IVector<JumpListItem> Items { [MethodImpl] get; }

    /// <summary>Gets or sets the current type of the system managed jump list group.</summary>
    /// <returns>The JumpListItemKind enumeration value of the jump list.</returns>
    public extern JumpListSystemGroupKind SystemGroupKind { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Asynchronously saves changes to the jump list and its items.</summary>
    /// <returns>Returns an IAsyncAction object that is used to control the asynchronous operation. If the system does not support jump lists, the SaveAsync method has no effect and future calls to LoadCurrentAsync will produce an empty jump list. An app can check for this case using the IsSupported method.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction SaveAsync();

    /// <summary>Asynchronously retrieves the current jump list and its items.</summary>
    /// <returns>When this method completes successfully, it returns the current JumpList. If the system does not support jump lists, this method returns an empty jump list and the SaveAsync method has no effect. Apps can check for this case using the isSupported method.</returns>
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<JumpList> LoadCurrentAsync();

    /// <summary>Gets a value that indicates whether the system supports jump lists.</summary>
    /// <returns>A boolean value that is True if jump lists are supported. Otherwise, False.</returns>
    [MethodImpl]
    public static extern bool IsSupported();
  }
}
