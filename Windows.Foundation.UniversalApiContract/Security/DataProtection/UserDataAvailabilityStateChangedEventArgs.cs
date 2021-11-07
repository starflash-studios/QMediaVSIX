// Decompiled with JetBrains decompiler
// Type: Windows.Security.DataProtection.UserDataAvailabilityStateChangedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Security.DataProtection
{
  /// <summary>Contains information about UserDataAvailabilityStateChangedEvent.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  [Threading(ThreadingModel.Both)]
  public sealed class UserDataAvailabilityStateChangedEventArgs : 
    IUserDataAvailabilityStateChangedEventArgs
  {
    /// <summary>Returns a Deferral object that can be used to block future events delivered on the UserDataProtectionManager object that was used to register for the event. Callers can call 'Complete' method on the Deferral object to unblock future events.</summary>
    /// <returns>The Deferral object.</returns>
    [MethodImpl]
    public extern Deferral GetDeferral();
  }
}
