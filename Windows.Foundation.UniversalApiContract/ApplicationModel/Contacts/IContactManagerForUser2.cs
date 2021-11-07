// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Contacts.IContactManagerForUser2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Contacts
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [ExclusiveTo(typeof (ContactManagerForUser))]
  [Guid(1296473134, 15221, 19059, 187, 48, 115, 102, 69, 71, 34, 86)]
  internal interface IContactManagerForUser2
  {
    void ShowFullContactCard(Contact contact, FullContactCardOptions fullContactCardOptions);
  }
}
