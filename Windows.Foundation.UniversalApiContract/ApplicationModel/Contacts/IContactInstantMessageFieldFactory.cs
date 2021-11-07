// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Contacts.IContactInstantMessageFieldFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Contacts
{
  /// <summary>Creates fields with information about a contact's instant messaging accounts.</summary>
  [Guid(3121309588, 37283, 19378, 177, 185, 105, 165, 223, 240, 186, 9)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public interface IContactInstantMessageFieldFactory
  {
    /// <summary>Creates a field containing information about a contact's instant messaging account.</summary>
    /// <param name="userName">The user name of the instant messaging account.</param>
    /// <returns>An instant messaging field that you can add to a Contact object.</returns>
    [Overload("CreateInstantMessage_Default")]
    ContactInstantMessageField CreateInstantMessage(string userName);

    /// <summary>Creates a field containing information about a contact's instant messaging account.</summary>
    /// <param name="userName">The user name for the instant messaging account.</param>
    /// <param name="category">The category the field belongs to.</param>
    /// <returns>An instant messaging field that you can add to a Contact object.</returns>
    [Overload("CreateInstantMessage_Category")]
    ContactInstantMessageField CreateInstantMessage(
      string userName,
      ContactFieldCategory category);

    [Overload("CreateInstantMessage_All")]
    ContactInstantMessageField CreateInstantMessage(
      string userName,
      ContactFieldCategory category,
      string service,
      string displayText,
      Uri verb);
  }
}
