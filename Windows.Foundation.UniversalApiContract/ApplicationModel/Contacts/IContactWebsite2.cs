// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Contacts.IContactWebsite2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Contacts
{
  [ExclusiveTo(typeof (ContactWebsite))]
  [Guid(4169066782, 22087, 16488, 187, 94, 75, 111, 67, 124, 227, 8)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IContactWebsite2 : IContactWebsite
  {
    string RawValue { get; set; }
  }
}
