// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Contacts.ContactPanelClosingEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Contacts
{
  /// <summary>Provides event information for the Closing event.</summary>
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class ContactPanelClosingEventArgs : IContactPanelClosingEventArgs
  {
    /// <summary>Gets the deferral object for the Closing event.</summary>
    /// <returns>The deferral object for the Closing event.</returns>
    [MethodImpl]
    public extern Deferral GetDeferral();
  }
}
