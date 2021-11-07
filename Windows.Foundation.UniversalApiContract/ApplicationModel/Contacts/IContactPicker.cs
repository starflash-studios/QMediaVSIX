// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Contacts.IContactPicker
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Contacts
{
  [ExclusiveTo(typeof (ContactPicker))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(235535761, 17144, 16469, 144, 160, 137, 111, 150, 115, 137, 54)]
  internal interface IContactPicker
  {
    string CommitButtonText { get; set; }

    ContactSelectionMode SelectionMode { get; set; }

    IVector<string> DesiredFields { get; }

    IAsyncOperation<ContactInformation> PickSingleContactAsync();

    IAsyncOperation<IVectorView<ContactInformation>> PickMultipleContactsAsync();
  }
}
