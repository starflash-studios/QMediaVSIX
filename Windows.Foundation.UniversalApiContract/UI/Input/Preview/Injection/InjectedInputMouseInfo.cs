// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Preview.Injection.InjectedInputMouseInfo
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input.Preview.Injection
{
  /// <summary>Represents programmatically generated mouse input.</summary>
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Activatable(196608, "Windows.Foundation.UniversalApiContract")]
  public sealed class InjectedInputMouseInfo : IInjectedInputMouseInfo
  {
    /// <summary>Creates a new InjectedInputMouseInfo object that is used to specify the mouse input to inject.</summary>
    [MethodImpl]
    public extern InjectedInputMouseInfo();

    /// <summary>Gets or sets the various options, or modifiers, used to simulate mouse input.</summary>
    /// <returns>The options, or modifiers, for the mouse input.</returns>
    public extern InjectedInputMouseOptions MouseOptions { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value used by other properties. The value is based on the MouseOptions flags set.</summary>
    /// <returns>The value used by other properties.</returns>
    public extern uint MouseData { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the change in value of an x-coordinate since the last mouse wheel event.</summary>
    /// <returns>The number of notches or distance thresholds crossed since the last pointer event. The default value is 0.</returns>
    public extern int DeltaY { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the change in value of an x-coordinate since the last mouse wheel event.</summary>
    /// <returns>The number of notches or distance thresholds crossed since the last pointer event. The default value is 0.</returns>
    public extern int DeltaX { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the baseline, or reference value, for timed input events such as a double click/tap.</summary>
    /// <returns>The reference value for timed input events in milliseconds. If TimeOffsetInMilliseconds is set to 0, the current tick count is used.</returns>
    public extern uint TimeOffsetInMilliseconds { [MethodImpl] get; [MethodImpl] set; }
  }
}
