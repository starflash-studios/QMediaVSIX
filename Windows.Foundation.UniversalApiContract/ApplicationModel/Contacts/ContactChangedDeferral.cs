// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Contacts.ContactChangedDeferral
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Contacts
{
  /// <summary>The deferral object to use while asynchronously processing ContactChanged events.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  public sealed class ContactChangedDeferral : IContactChangedDeferral
  {
    /// <summary>Call this method in order to release the deferral object when all asynchronous processing has finished.</summary>
    [MethodImpl]
    public extern void Complete();
  }
}
