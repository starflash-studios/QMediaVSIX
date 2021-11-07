// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Preview.Injection.InjectedInputPointerInfo
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input.Preview.Injection
{
  /// <summary>Contains basic pointer information common to all pointer types.</summary>
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  public struct InjectedInputPointerInfo
  {
    /// <summary>A unique identifier for the lifetime of the pointer. A pointer is created when it enters detection range and destroyed when it leaves detection range. If a pointer goes out of detection range and then returns, it is treated as a new pointer and might be assigned a new identifier.</summary>
    public uint PointerId;
    /// <summary>The various options, or modifiers, used to simulate pointer input through InjectedInputMouseInfo, InjectedInputPenInfo, and InjectedInputTouchInfo.</summary>
    public InjectedInputPointerOptions PointerOptions;
    /// <summary>The screen coordinates of the pointer in device-independent pixel (DIP).</summary>
    public InjectedInputPoint PixelLocation;
    /// <summary>The baseline, or reference value, in milliseconds, for timed input events such as a double click/tap.</summary>
    public uint TimeOffsetInMilliseconds;
    /// <summary>A high resolution (less than one microsecond) time stamp used for time-interval measurements.</summary>
    public ulong PerformanceCount;
  }
}
