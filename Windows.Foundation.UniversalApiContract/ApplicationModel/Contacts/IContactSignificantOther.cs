// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Contacts.IContactSignificantOther
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Contacts
{
  [Guid(2289284523, 50683, 18136, 147, 254, 218, 63, 241, 147, 64, 84)]
  [ExclusiveTo(typeof (ContactSignificantOther))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IContactSignificantOther
  {
    string Name { get; set; }

    string Description { get; set; }
  }
}
