// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Contacts.ContactPanel
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI;

namespace Windows.ApplicationModel.Contacts
{
  /// <summary>Represents a Contact Panel that appears when users click a contact that is pinned to the taskbar.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  public sealed class ContactPanel : IContactPanel
  {
    /// <summary>Closes the Contact Panel.</summary>
    [MethodImpl]
    public extern void ClosePanel();

    /// <summary>Specifies the color of the Contact Panel header.</summary>
    /// <returns>A Color  that represents the desired color.</returns>
    public extern IReference<Color> HeaderColor { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Occurs when the user clicks the **Launch Full App** button in the Contact Panel.</summary>
    public extern event TypedEventHandler<ContactPanel, ContactPanelLaunchFullAppRequestedEventArgs> LaunchFullAppRequested;

    /// <summary>Occurs when the Contact Panel is closing.</summary>
    public extern event TypedEventHandler<ContactPanel, ContactPanelClosingEventArgs> Closing;
  }
}
