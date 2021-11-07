// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Contacts.ContactInstantMessageField
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Contacts
{
  /// <summary>Defines a field that is an instant messaging (IM) address.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(typeof (IContactInstantMessageFieldFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class ContactInstantMessageField : IContactInstantMessageField, IContactField
  {
    /// <summary>Creates a new ContactInstantMessageField object.</summary>
    /// <param name="userName">The user's name.</param>
    [MethodImpl]
    public extern ContactInstantMessageField(string userName);

    /// <summary>Creates a new ContactInstantMessageField object.</summary>
    /// <param name="userName">The user's name.</param>
    /// <param name="category">The category of contact data.</param>
    [MethodImpl]
    public extern ContactInstantMessageField(string userName, ContactFieldCategory category);

    [MethodImpl]
    public extern ContactInstantMessageField(
      string userName,
      ContactFieldCategory category,
      string service,
      string displayText,
      Uri verb);

    /// <summary>Gets the user's name.</summary>
    /// <returns>The user's name.</returns>
    public extern string UserName { [MethodImpl] get; }

    /// <summary>Gets the name of the service used for sending instant messages.</summary>
    /// <returns>The service name.</returns>
    public extern string Service { [MethodImpl] get; }

    /// <summary>Gets the display text for the Uniform Resource Identifier (URI)that starts an instant message.</summary>
    /// <returns>The display text.</returns>
    public extern string DisplayText { [MethodImpl] get; }

    /// <summary>Gets the Uniform Resource Identifier (URI)that can start an instant message.</summary>
    /// <returns>The Uniform Resource Identifier (URI).</returns>
    public extern Uri LaunchUri { [MethodImpl] get; }

    /// <summary>Gets the contact field type for the data.</summary>
    /// <returns>The type of data.</returns>
    public extern ContactFieldType Type { [MethodImpl] get; }

    /// <summary>Gets the category for the contact data.</summary>
    /// <returns>The category for the contact data.</returns>
    public extern ContactFieldCategory Category { [MethodImpl] get; }

    /// <summary>Gets the name of the field.</summary>
    /// <returns>The name of the field.</returns>
    public extern string Name { [MethodImpl] get; }

    /// <summary>Gets the value of the contact data.</summary>
    /// <returns>The value of the contact data.</returns>
    public extern string Value { [MethodImpl] get; }
  }
}
