// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Contacts.DataProvider.IContactListCreateOrUpdateContactRequestEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Contacts.DataProvider
{
  [ExclusiveTo(typeof (ContactListCreateOrUpdateContactRequestEventArgs))]
  [Guid(2233210512, 6737, 19212, 174, 239, 18, 64, 172, 91, 237, 117)]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  internal interface IContactListCreateOrUpdateContactRequestEventArgs
  {
    ContactListCreateOrUpdateContactRequest Request { get; }

    Deferral GetDeferral();
  }
}
