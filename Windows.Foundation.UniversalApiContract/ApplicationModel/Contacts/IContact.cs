// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Contacts.IContact
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.ApplicationModel.Contacts
{
  [ExclusiveTo(typeof (Contact))]
  [Guid(3959452403, 8472, 16457, 158, 188, 23, 240, 171, 105, 43, 100)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IContact
  {
    string Name { get; set; }

    IRandomAccessStreamReference Thumbnail { get; set; }

    IVector<IContactField> Fields { get; }
  }
}
