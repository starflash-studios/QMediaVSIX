// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Contacts.IContactDate
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Contacts
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (ContactDate))]
  [Guid(4271418982, 45573, 18740, 145, 116, 15, 242, 176, 86, 87, 7)]
  internal interface IContactDate
  {
    IReference<uint> Day { get; set; }

    IReference<uint> Month { get; set; }

    IReference<int> Year { get; set; }

    ContactDateKind Kind { get; set; }

    string Description { get; set; }
  }
}
