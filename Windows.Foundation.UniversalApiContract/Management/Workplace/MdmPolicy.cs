// Decompiled with JetBrains decompiler
// Type: Windows.Management.Workplace.MdmPolicy
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Management.Workplace
{
  /// <summary>MDM (Mobile Device Management) policy.</summary>
  [Static(typeof (IMdmPolicyStatics2), 196608, "Windows.Foundation.UniversalApiContract")]
  [DualApiPartition(version = 1)]
  [Static(typeof (IMdmAllowPolicyStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public static class MdmPolicy
  {
    /// <summary>Gets the current messaging sync policy.</summary>
    /// <returns>The messaging sync policy.</returns>
    [MethodImpl]
    public static extern MessagingSyncPolicy GetMessagingSyncPolicy();

    /// <summary>Returns **true** if a browser is allowed.</summary>
    /// <returns>**true** if a browser is allowed.</returns>
    [MethodImpl]
    public static extern bool IsBrowserAllowed();

    /// <summary>Returns **true** if a camera is allowed.</summary>
    /// <returns>**true** if a camera is allowed.</returns>
    [MethodImpl]
    public static extern bool IsCameraAllowed();

    /// <summary>Returns **true** if a Microsoft Account is allowed.</summary>
    /// <returns>**true** if a Microsoft Account is allowed.</returns>
    [MethodImpl]
    public static extern bool IsMicrosoftAccountAllowed();

    /// <summary>Returns **true** if a Store is allowed.</summary>
    /// <returns>**true** if a Store is allowed.</returns>
    [MethodImpl]
    public static extern bool IsStoreAllowed();
  }
}
