// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Contacts.IContactEmail
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Contacts
{
  [Guid(2426542505, 58323, 19811, 153, 59, 5, 185, 165, 57, 58, 191)]
  [ExclusiveTo(typeof (ContactEmail))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IContactEmail
  {
    string Address { get; set; }

    ContactEmailKind Kind { get; set; }

    string Description { get; set; }
  }
}
