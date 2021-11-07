// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Contacts.IContactPickerStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.System;

namespace Windows.ApplicationModel.Contacts
{
  [ExclusiveTo(typeof (ContactPicker))]
  [Guid(1955119145, 27219, 16984, 163, 233, 98, 223, 246, 120, 75, 108)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  internal interface IContactPickerStatics
  {
    ContactPicker CreateForUser(User user);

    [RemoteAsync]
    IAsyncOperation<bool> IsSupportedAsync();
  }
}
