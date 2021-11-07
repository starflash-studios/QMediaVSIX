// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Contacts.ContactChangedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Contacts
{
  /// <summary>Provides data for the ContactChanged event.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  public sealed class ContactChangedEventArgs : IContactChangedEventArgs
  {
    /// <summary>Gets the ContactChangedDeferral object to use for asynchronous operations.</summary>
    /// <returns>The deferral object to use for asynchronous operations.</returns>
    [MethodImpl]
    public extern ContactChangedDeferral GetDeferral();
  }
}
