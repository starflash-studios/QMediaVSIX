// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Contacts.ContactQueryTextSearch
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Contacts
{
  /// <summary>Specifies parameters to use in a text search of Contact objects.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class ContactQueryTextSearch : IContactQueryTextSearch
  {
    /// <summary>Gets or sets which contact fields to search for a text match.</summary>
    /// <returns>Specifies which contact fields to search for a text match.</returns>
    public extern ContactQuerySearchFields Fields { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the text for which to search.</summary>
    /// <returns>The text for which to search.</returns>
    public extern string Text { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that specifies either a local or server search.</summary>
    /// <returns>A value that specifies either a local or server search.</returns>
    public extern ContactQuerySearchScope SearchScope { [MethodImpl] get; [MethodImpl] set; }
  }
}
