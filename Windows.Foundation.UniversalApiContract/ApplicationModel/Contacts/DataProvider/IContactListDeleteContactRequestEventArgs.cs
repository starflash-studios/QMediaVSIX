// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Contacts.DataProvider.IContactListDeleteContactRequestEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Contacts.DataProvider
{
  [ExclusiveTo(typeof (ContactListDeleteContactRequestEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [Guid(2988463265, 59642, 19893, 147, 137, 45, 18, 238, 125, 21, 238)]
  internal interface IContactListDeleteContactRequestEventArgs
  {
    ContactListDeleteContactRequest Request { get; }

    Deferral GetDeferral();
  }
}
