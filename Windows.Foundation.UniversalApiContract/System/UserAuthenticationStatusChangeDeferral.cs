// Decompiled with JetBrains decompiler
// Type: Windows.System.UserAuthenticationStatusChangeDeferral
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System
{
  /// <summary>Represents a user authentication status change deferral returned by the UserAuthenticationStatusChangingEventArgs.GetDeferral method.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 167772160)]
  public sealed class UserAuthenticationStatusChangeDeferral : 
    IUserAuthenticationStatusChangeDeferral
  {
    /// <summary>Reports that the application has completed its user authentication status change deferral.</summary>
    [MethodImpl]
    public extern void Complete();
  }
}
