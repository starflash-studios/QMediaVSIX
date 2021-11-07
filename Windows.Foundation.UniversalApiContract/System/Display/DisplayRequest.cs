// Decompiled with JetBrains decompiler
// Type: Windows.System.Display.DisplayRequest
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.Display
{
  /// <summary>Represents a display request.</summary>
  [MarshalingBehavior(MarshalingType.None)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.STA)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class DisplayRequest : IDisplayRequest
  {
    /// <summary>Creates an instance of the DisplayRequest class.</summary>
    [MethodImpl]
    public extern DisplayRequest();

    /// <summary>Activates a display request.</summary>
    [MethodImpl]
    public extern void RequestActive();

    /// <summary>Deactivates a display request.</summary>
    [MethodImpl]
    public extern void RequestRelease();
  }
}
