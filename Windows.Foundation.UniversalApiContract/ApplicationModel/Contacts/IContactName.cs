// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Contacts.IContactName
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Contacts
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(4093962619, 36916, 17724, 142, 191, 20, 10, 56, 200, 111, 29)]
  [ExclusiveTo(typeof (Contact))]
  internal interface IContactName
  {
    string FirstName { get; set; }

    string LastName { get; set; }

    string MiddleName { get; set; }

    string YomiGivenName { get; set; }

    string YomiFamilyName { get; set; }

    string HonorificNameSuffix { get; set; }

    string HonorificNamePrefix { get; set; }

    string DisplayName { get; }

    string YomiDisplayName { get; }
  }
}
