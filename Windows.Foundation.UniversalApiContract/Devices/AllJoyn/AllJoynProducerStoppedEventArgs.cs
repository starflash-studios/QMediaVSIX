// Decompiled with JetBrains decompiler
// Type: Windows.Devices.AllJoyn.AllJoynProducerStoppedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.AllJoyn
{
  /// <summary>Contains status information that indicates why a Producer app was stopped.</summary>
  [DualApiPartition(version = 167772160)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Deprecated("AllJoynProducerStoppedEventArgs has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract")]
  [Activatable(typeof (IAllJoynProducerStoppedEventArgsFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class AllJoynProducerStoppedEventArgs : IAllJoynProducerStoppedEventArgs
  {
    /// <summary>Generates an object containing status information for the stopped Producer app.</summary>
    /// <param name="status">An AllJoyn status code that indicates why the Producer was stopped.</param>
    [Deprecated("AllJoynProducerStoppedEventArgs has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public extern AllJoynProducerStoppedEventArgs(int status);

    /// <summary>Returns an AllJoyn status code that indicates why the Producer was stopped. Common values are defined by AllJoynStatus.</summary>
    /// <returns>The AllJoyn status code.</returns>
    public extern int Status { [Deprecated("AllJoynProducerStoppedEventArgs has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }
  }
}
