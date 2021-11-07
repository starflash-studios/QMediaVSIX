// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Contacts.DataProvider.ContactDataProviderTriggerDetails
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Contacts.DataProvider
{
  /// <summary>Contains details about the event that triggered your contact data provider background task.</summary>
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class ContactDataProviderTriggerDetails : IContactDataProviderTriggerDetails
  {
    /// <summary>Gets the ContactDataProviderConnection object instance used to provide contact data to a client app.</summary>
    /// <returns>The ContactDataProviderConnection object your contact data provider uses to communicate with a client app.</returns>
    public extern ContactDataProviderConnection Connection { [MethodImpl] get; }
  }
}
