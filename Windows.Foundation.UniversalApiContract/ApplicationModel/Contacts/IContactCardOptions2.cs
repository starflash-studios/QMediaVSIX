// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Contacts.IContactCardOptions2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Contacts
{
  [ExclusiveTo(typeof (ContactCardOptions))]
  [Guid(2401704864, 55115, 19654, 159, 83, 27, 14, 181, 209, 39, 60)]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  internal interface IContactCardOptions2 : IContactCardOptions
  {
    IVector<string> ServerSearchContactListIds { get; }
  }
}
