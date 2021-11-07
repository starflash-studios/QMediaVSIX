// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Contacts.IContactPanelLaunchFullAppRequestedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Contacts
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(2295733262, 9140, 19432, 138, 252, 7, 44, 37, 164, 25, 13)]
  [ExclusiveTo(typeof (ContactPanelLaunchFullAppRequestedEventArgs))]
  internal interface IContactPanelLaunchFullAppRequestedEventArgs
  {
    bool Handled { get; set; }
  }
}
