// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Contacts.IContactPanel
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI;

namespace Windows.ApplicationModel.Contacts
{
  [ExclusiveTo(typeof (ContactPanel))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(1103041125, 53998, 19351, 168, 10, 125, 141, 100, 204, 166, 245)]
  internal interface IContactPanel
  {
    void ClosePanel();

    IReference<Color> HeaderColor { get; set; }

    event TypedEventHandler<ContactPanel, ContactPanelLaunchFullAppRequestedEventArgs> LaunchFullAppRequested;

    event TypedEventHandler<ContactPanel, ContactPanelClosingEventArgs> Closing;
  }
}
