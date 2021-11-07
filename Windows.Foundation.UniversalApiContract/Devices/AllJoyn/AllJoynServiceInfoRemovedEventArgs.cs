// Decompiled with JetBrains decompiler
// Type: Windows.Devices.AllJoyn.AllJoynServiceInfoRemovedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.AllJoyn
{
  /// <summary>Contains information that identifies an advertising app that is no longer available.</summary>
  [Deprecated("AllJoynServiceInfoRemovedEventArgs has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract")]
  [Activatable(typeof (IAllJoynServiceInfoRemovedEventArgsFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 167772160)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class AllJoynServiceInfoRemovedEventArgs : IAllJoynServiceInfoRemovedEventArgs
  {
    /// <summary>Generates an object containing information about an advertising app that is no longer available.</summary>
    /// <param name="uniqueName">The unique app name.</param>
    [Deprecated("AllJoynServiceInfoRemovedEventArgs has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public extern AllJoynServiceInfoRemovedEventArgs(string uniqueName);

    /// <summary>The unique bus name of the advertising app that is no longer available.</summary>
    /// <returns>The unique bus name.</returns>
    public extern string UniqueName { [Deprecated("AllJoynServiceInfoRemovedEventArgs has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }
  }
}
