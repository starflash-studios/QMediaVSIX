// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Display.DisplayEnhancementOverrideCapabilitiesChangedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Display
{
  /// <summary>Provides the arguments returned by the event raised when the display enhancement override changes.</summary>
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  public sealed class DisplayEnhancementOverrideCapabilitiesChangedEventArgs : 
    IDisplayEnhancementOverrideCapabilitiesChangedEventArgs
  {
    /// <summary>Gets the display enhancement override capabilities that have changed.</summary>
    /// <returns>The display enhancement override capabilities that have changed.</returns>
    public extern DisplayEnhancementOverrideCapabilities Capabilities { [MethodImpl] get; }
  }
}
