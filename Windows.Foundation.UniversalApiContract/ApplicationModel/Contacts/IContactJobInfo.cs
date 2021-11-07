// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Contacts.IContactJobInfo
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Contacts
{
  [ExclusiveTo(typeof (ContactJobInfo))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1829862220, 52816, 19267, 158, 105, 177, 130, 88, 234, 83, 21)]
  internal interface IContactJobInfo
  {
    string CompanyName { get; set; }

    string CompanyYomiName { get; set; }

    string Department { get; set; }

    string Title { get; set; }

    string Manager { get; set; }

    string Office { get; set; }

    string CompanyAddress { get; set; }

    string Description { get; set; }
  }
}
