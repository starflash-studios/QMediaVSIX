// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Calls.PhoneCallHistoryManager
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.System;

namespace Windows.ApplicationModel.Calls
{
  /// <summary>Provides APIs for the application to get access to the PhoneCallHistoryStore.</summary>
  [Static(typeof (IPhoneCallHistoryManagerStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [Static(typeof (IPhoneCallHistoryManagerStatics2), 196608, "Windows.Foundation.UniversalApiContract")]
  public static class PhoneCallHistoryManager
  {
    /// <summary>Gets the PhoneCallHistoryManagerForUser object for a specific user which provides access to the PhoneCallHistoryStore for a specific user.</summary>
    /// <param name="user">The user that you are interested in.</param>
    /// <returns>The PhoneCallHistoryManagerForUser object that enables you to gain access to the PhoneCallHistoryStore object.</returns>
    [MethodImpl]
    public static extern PhoneCallHistoryManagerForUser GetForUser(
      User user);

    /// <summary>Requests the PhoneCallHistoryStore associated with the calling application.</summary>
    /// <param name="accessType">The type of access requested for the PhoneCallHistoryStore object.</param>
    /// <returns>An asynchronous operation that returns a PhoneCallHistoryStore object on successful completion.</returns>
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<PhoneCallHistoryStore> RequestStoreAsync(
      PhoneCallHistoryStoreAccessType accessType);
  }
}
