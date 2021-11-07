// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Contacts.ContactMatchReason
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Data.Text;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Contacts
{
  /// <summary>Provides details about why search results matched the query parameters.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class ContactMatchReason : IContactMatchReason
  {
    /// <summary>Gets the contact field type that matched the search, such as name, phone number, email address and so on.</summary>
    /// <returns>The contact field type that matched the search, such as name, phone number, email address and so on.</returns>
    public extern ContactMatchReasonKind Field { [MethodImpl] get; }

    /// <summary>Gets a list of matching TextSegment objects which tells you what to highlight in your view as the result of a contact search.</summary>
    /// <returns>The list of matching TextSegment objects.</returns>
    public extern IVectorView<TextSegment> Segments { [MethodImpl] get; }

    /// <summary>Gets the matching text result from a contact search.</summary>
    /// <returns>The matching text result from a contact search.</returns>
    public extern string Text { [MethodImpl] get; }
  }
}
