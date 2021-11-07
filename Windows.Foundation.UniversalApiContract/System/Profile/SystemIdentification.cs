// Decompiled with JetBrains decompiler
// Type: Windows.System.Profile.SystemIdentification
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.Profile
{
  /// <summary>Provides information to uniquely identify the system on which the app is running.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 167772162)]
  [Static(typeof (ISystemIdentificationStatics), 196608, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Threading(ThreadingModel.Both)]
  public static class SystemIdentification
  {
    /// <summary>Gets an identifier value for the system based on the app publisher ID.</summary>
    /// <returns>A SystemIdentificationInfo object for this system, based on the app publisher ID.</returns>
    [MethodImpl]
    public static extern SystemIdentificationInfo GetSystemIdForPublisher();

    /// <summary>Gets an identifier value for the system based on the user ID.</summary>
    /// <param name="user">The User data to use for creating the system ID. If the value is `null`, this method will get the current user's ID.</param>
    /// <returns>A SystemIdentificationInfo object for this system, based on the user ID.</returns>
    [MethodImpl]
    public static extern SystemIdentificationInfo GetSystemIdForUser(
      User user);
  }
}
