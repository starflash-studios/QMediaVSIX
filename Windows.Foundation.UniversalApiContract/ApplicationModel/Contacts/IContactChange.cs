// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Contacts.IContactChange
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Contacts
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2501724944, 27225, 18208, 164, 225, 54, 61, 152, 193, 53, 213)]
  [ExclusiveTo(typeof (ContactChange))]
  internal interface IContactChange
  {
    ContactChangeType ChangeType { get; }

    Contact Contact { get; }
  }
}
