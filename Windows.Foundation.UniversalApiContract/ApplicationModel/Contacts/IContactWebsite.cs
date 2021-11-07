// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Contacts.IContactWebsite
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Contacts
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (ContactWebsite))]
  [Guid(2668822902, 56347, 16469, 173, 102, 101, 47, 57, 217, 144, 232)]
  internal interface IContactWebsite
  {
    Uri Uri { get; set; }

    string Description { get; set; }
  }
}
