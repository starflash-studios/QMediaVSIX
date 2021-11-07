// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Contacts.IContactPhone
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Contacts
{
  [ExclusiveTo(typeof (ContactPhone))]
  [Guid(1182640997, 10002, 20306, 183, 131, 158, 168, 17, 28, 99, 205)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IContactPhone
  {
    string Number { get; set; }

    ContactPhoneKind Kind { get; set; }

    string Description { get; set; }
  }
}
