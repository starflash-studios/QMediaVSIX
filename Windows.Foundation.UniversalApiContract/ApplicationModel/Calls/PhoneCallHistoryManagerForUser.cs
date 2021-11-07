// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Calls.PhoneCallHistoryManagerForUser
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.System;

namespace Windows.ApplicationModel.Calls
{
  /// <summary>Provides APIs for the application to get access to the PhoneCallHistoryStore for a specific user.</summary>
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class PhoneCallHistoryManagerForUser : IPhoneCallHistoryManagerForUser
  {
    /// <summary>Requests the PhoneCallHistoryStore associated with the associated user and the calling application.</summary>
    /// <param name="accessType">The type of access requested for the PhoneCallHistoryStore object.</param>
    /// <returns>An asynchronous operation that returns a PhoneCallHistoryStore object on successful completion.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<PhoneCallHistoryStore> RequestStoreAsync(
      PhoneCallHistoryStoreAccessType accessType);

    /// <summary>Gets the user of an app.</summary>
    /// <returns>The user object that enables you to retrieve a PhoneCallHistoryStore for a specific user of an app.</returns>
    public extern User User { [MethodImpl] get; }
  }
}
