// Decompiled with JetBrains decompiler
// Type: Windows.Media.Protection.HdcpSession
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Protection
{
  /// <summary>Allows apps to set and query the current state of High-bandwidth Digital Content Protection (HDCP) between the graphics hardware and the display.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 167772162)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Activatable(196608, "Windows.Foundation.UniversalApiContract")]
  public sealed class HdcpSession : IHdcpSession, IClosable
  {
    /// <summary>Initializes a new instance of the **HdcpSession** class.</summary>
    [MethodImpl]
    public extern HdcpSession();

    /// <summary>Checks whether the effective protection of the HdcpSession instance is at least equal to the given HdcpProtection value.</summary>
    /// <param name="protection">The level of protection to check against the HdcpSession instance's protection level.</param>
    /// <returns>True if the protection level of the HdcpSession is at least equal to the value of *protection*.</returns>
    [MethodImpl]
    public extern bool IsEffectiveProtectionAtLeast(HdcpProtection protection);

    /// <summary>Returns the effective protection of the HdcpSession instance.</summary>
    /// <returns>The level of protection that the HdcpSession instance currently has.</returns>
    [MethodImpl]
    public extern IReference<HdcpProtection> GetEffectiveProtection();

    /// <summary>Asynchronously attempts to set the protection of the HdcpSession instance with the given protection level.</summary>
    /// <param name="protection">The level of protection at which to set the HdcpSession instance.</param>
    /// <returns>The result of the operation.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<HdcpSetProtectionResult> SetDesiredMinProtectionAsync(
      HdcpProtection protection);

    /// <summary>Fires when the protection level of the HdcpSession instance changes.</summary>
    public extern event TypedEventHandler<HdcpSession, object> ProtectionChanged;

    [MethodImpl]
    public extern void Close();
  }
}
