// Decompiled with JetBrains decompiler
// Type: Windows.System.UserProfile.AdvertisingManagerForUser
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.UserProfile
{
  /// <summary>Associates a user with an advertising ID.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [DualApiPartition(version = 167772162)]
  [Threading(ThreadingModel.Both)]
  public sealed class AdvertisingManagerForUser : IAdvertisingManagerForUser
  {
    /// <summary>Gets a unique ID used to provide more relevant advertising to a user.</summary>
    /// <returns>The advertising ID is represented as an alphanumeric string. When the advertising ID feature is turned off, this is an empty string.</returns>
    public extern string AdvertisingId { [MethodImpl] get; }

    /// <summary>Gets the user who is associated with the advertising ID.</summary>
    /// <returns>The user who is associated with the advertising ID.</returns>
    public extern User User { [MethodImpl] get; }
  }
}
