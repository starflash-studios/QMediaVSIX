// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Input.MouseEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Input
{
  /// <summary>Contains event data for the MouseMoved event.</summary>
  [MarshalingBehavior(MarshalingType.Standard)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class MouseEventArgs : IMouseEventArgs
  {
    /// <summary>Gets a value that indicates the change in the screen location of the mouse pointer since the last mouse event.</summary>
    /// <returns>The change in screen location of the mouse pointer, relative to the location of the last mouse event.</returns>
    public extern MouseDelta MouseDelta { [MethodImpl] get; }
  }
}
