// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Contacts.IContactAnnotation
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Contacts
{
  [ExclusiveTo(typeof (ContactAnnotation))]
  [Guid(2183119599, 32065, 17570, 132, 195, 96, 162, 129, 221, 123, 134)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IContactAnnotation
  {
    string Id { get; }

    string AnnotationListId { get; }

    string ContactId { get; set; }

    string RemoteId { get; set; }

    ContactAnnotationOperations SupportedOperations { get; set; }

    bool IsDisabled { get; }

    ValueSet ProviderProperties { get; }
  }
}
