// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Contacts.IContactCardDelayedDataLoader
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Contacts
{
  [ExclusiveTo(typeof (ContactCardDelayedDataLoader))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3054172418, 5446, 17229, 134, 156, 110, 53, 32, 118, 14, 243)]
  internal interface IContactCardDelayedDataLoader : IClosable
  {
    void SetData(Contact contact);
  }
}
