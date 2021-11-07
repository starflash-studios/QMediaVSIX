// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Contacts.IContactQueryOptions
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Contacts
{
  [Guid(1141427358, 32124, 17136, 138, 199, 245, 7, 51, 236, 219, 193)]
  [ExclusiveTo(typeof (ContactQueryOptions))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IContactQueryOptions
  {
    ContactQueryTextSearch TextSearch { get; }

    IVector<string> ContactListIds { get; }

    bool IncludeContactsFromHiddenLists { get; set; }

    ContactQueryDesiredFields DesiredFields { get; set; }

    ContactAnnotationOperations DesiredOperations { get; set; }

    IVector<string> AnnotationListIds { get; }
  }
}
