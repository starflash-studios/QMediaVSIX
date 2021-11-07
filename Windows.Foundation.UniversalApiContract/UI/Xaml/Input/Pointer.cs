// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Input.Pointer
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Devices.Input;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Input
{
  /// <summary>Provides basic properties for the input pointer associated with a single mouse, pen/stylus, or touch contact.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [WebHostHidden]
  public sealed class Pointer : IPointer
  {
    /// <summary>Gets the system-generated identifier for this pointer reference.</summary>
    /// <returns>The system-generated identifier.</returns>
    public extern uint PointerId { [MethodImpl] get; }

    /// <summary>Gets the PointerDeviceType for the pointer device.</summary>
    /// <returns>The PointerDeviceType for this pointer reference.</returns>
    public extern PointerDeviceType PointerDeviceType { [MethodImpl] get; }

    /// <summary>Gets a value that determines whether the pointer device was in contact with a sensor or digitizer at the time that the event was reported.</summary>
    /// <returns>**true** if the pointer device was in contact; otherwise, **false**.</returns>
    public extern bool IsInContact { [MethodImpl] get; }

    /// <summary>Gets a value that indicates whether the pointer device is within detection range of a sensor or digitizer.</summary>
    /// <returns>**true** if touch or pen is within detection range or mouse is over; otherwise **false**</returns>
    public extern bool IsInRange { [MethodImpl] get; }
  }
}
