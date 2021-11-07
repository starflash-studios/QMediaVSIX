// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Email.IEmailQueryTextSearch
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Email
{
  [Guid(2678104712, 15453, 18085, 166, 226, 49, 214, 253, 23, 229, 64)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (EmailQueryTextSearch))]
  internal interface IEmailQueryTextSearch
  {
    EmailQuerySearchFields Fields { get; set; }

    EmailQuerySearchScope SearchScope { get; set; }

    string Text { get; set; }
  }
}
