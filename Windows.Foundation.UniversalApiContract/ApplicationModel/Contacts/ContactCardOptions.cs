// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Contacts.ContactCardOptions
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Contacts
{
  /// <summary>Represents data about how to display a mini contact card.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class ContactCardOptions : IContactCardOptions, IContactCardOptions2
  {
    /// <summary>Initializes a new instance of the ContactCardOptions class.</summary>
    [MethodImpl]
    public extern ContactCardOptions();

    /// <summary>Gets or sets a value that specifies the type of header to display on the contact card.</summary>
    /// <returns>The type of header to display on the contact card.</returns>
    public extern ContactCardHeaderKind HeaderKind { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates which tab to display first on a mini contact card.</summary>
    /// <returns>A value that indicates which tab to display first on a mini contact card.</returns>
    public extern ContactCardTabKind InitialTabKind { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets a list to which you can add ContactList.Id values to search for on the server.</summary>
    /// <returns>A list to which you can add ContactList.Id values to search for on the server.</returns>
    public extern IVector<string> ServerSearchContactListIds { [MethodImpl] get; }
  }
}
