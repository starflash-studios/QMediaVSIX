// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Contacts.IContactQueryTextSearch
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Contacts
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(4158912971, 43351, 17307, 160, 183, 28, 2, 161, 150, 63, 240)]
  [ExclusiveTo(typeof (ContactQueryTextSearch))]
  internal interface IContactQueryTextSearch
  {
    ContactQuerySearchFields Fields { get; set; }

    string Text { get; set; }

    ContactQuerySearchScope SearchScope { get; set; }
  }
}
