// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Contacts.ContactPanelLaunchFullAppRequestedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Contacts
{
  /// <summary>Provides event information for the LaunchFullAppRequested event.</summary>
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class ContactPanelLaunchFullAppRequestedEventArgs : 
    IContactPanelLaunchFullAppRequestedEventArgs
  {
    /// <summary>Gets or sets a value that indicates the LaunchFullAppRequested event has been handled.</summary>
    /// <returns>**true** if the LaunchFullAppRequested event is handled; **false** if the LaunchFullAppRequested event is not yet handled.</returns>
    public extern bool Handled { [MethodImpl] get; [MethodImpl] set; }
  }
}
