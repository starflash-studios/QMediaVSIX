// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Contacts.IContactQueryOptionsFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Contacts
{
  [Guid(1413462599, 36071, 18123, 157, 172, 154, 164, 42, 27, 200, 226)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (ContactQueryOptions))]
  internal interface IContactQueryOptionsFactory
  {
    ContactQueryOptions CreateWithText(string text);

    ContactQueryOptions CreateWithTextAndFields(
      string text,
      ContactQuerySearchFields fields);
  }
}
