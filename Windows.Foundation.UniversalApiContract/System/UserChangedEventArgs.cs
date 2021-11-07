// Decompiled with JetBrains decompiler
// Type: Windows.System.UserChangedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.System
{
  /// <summary>Provides data for a user changed event.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 167772160)]
  public sealed class UserChangedEventArgs : IUserChangedEventArgs, IUserChangedEventArgs2
  {
    /// <summary>Gets the user.</summary>
    /// <returns>The user.</returns>
    public extern User User { [MethodImpl] get; }

    /// <summary>
    /// </summary>
    /// <returns>
    /// </returns>
    public extern IVectorView<UserWatcherUpdateKind> ChangedPropertyKinds { [MethodImpl] get; }
  }
}
