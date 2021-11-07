// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Contacts.IContactManagerStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Popups;

namespace Windows.ApplicationModel.Contacts
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2180127424, 63073, 18184, 186, 79, 211, 134, 189, 13, 98, 46)]
  [ExclusiveTo(typeof (ContactManager))]
  internal interface IContactManagerStatics
  {
    [Overload("ShowContactCard")]
    void ShowContactCard(Contact contact, Rect selection);

    [Overload("ShowContactCardWithPlacement")]
    void ShowContactCard(Contact contact, Rect selection, Placement preferredPlacement);

    [Overload("ShowDelayLoadedContactCard")]
    ContactCardDelayedDataLoader ShowDelayLoadedContactCard(
      Contact contact,
      Rect selection,
      Placement preferredPlacement);
  }
}
