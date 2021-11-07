// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Contacts.IContactLocationField
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Contacts
{
  [Guid(2663387010, 43886, 19254, 137, 227, 178, 59, 192, 161, 218, 204)]
  [ExclusiveTo(typeof (ContactLocationField))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IContactLocationField : IContactField
  {
    string UnstructuredAddress { get; }

    string Street { get; }

    string City { get; }

    string Region { get; }

    string Country { get; }

    string PostalCode { get; }
  }
}
