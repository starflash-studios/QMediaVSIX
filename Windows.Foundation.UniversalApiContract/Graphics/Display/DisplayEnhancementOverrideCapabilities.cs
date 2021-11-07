// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Display.DisplayEnhancementOverrideCapabilities
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Display
{
  /// <summary>Describes the capabilities of a display enhancement override object.</summary>
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class DisplayEnhancementOverrideCapabilities : 
    IDisplayEnhancementOverrideCapabilities
  {
    /// <summary>Gets a value that describes whether brightness control is currently supported.</summary>
    /// <returns>**True** if brightness control is currently supported; otherwise, **false**.</returns>
    public extern bool IsBrightnessControlSupported { [MethodImpl] get; }

    /// <summary>Gets a value that describes whether brightness control in nits is supported.</summary>
    /// <returns>**True** if the brightness controls in nits is supported; otherwise, **false**.</returns>
    public extern bool IsBrightnessNitsControlSupported { [MethodImpl] get; }

    /// <summary>Retrieves the supported nit ranges.</summary>
    /// <returns>The supported nit ranges. Returns an empty vector if IsBrightnessNitsControlSupported is **false**.</returns>
    [MethodImpl]
    public extern IVectorView<NitRange> GetSupportedNitRanges();
  }
}
