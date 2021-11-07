// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Display.Core.DisplayManagerEnabledEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Display.Core
{
  /// <summary>Represents arguments for the Enabled event.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  public sealed class DisplayManagerEnabledEventArgs : IDisplayManagerEnabledEventArgs
  {
    /// <summary>Gets and sets a value indicating whether the Enabled event has been handled.</summary>
    /// <returns>`true` if the Enabled event has been handled, otherwise `false`.</returns>
    public extern bool Handled { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>A Deferral object representing the deferral.</summary>
    /// <returns>
    /// </returns>
    [MethodImpl]
    public extern Deferral GetDeferral();
  }
}
