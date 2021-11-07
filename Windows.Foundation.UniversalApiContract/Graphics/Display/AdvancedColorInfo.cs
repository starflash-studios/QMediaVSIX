// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Display.AdvancedColorInfo
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Display
{
  /// <summary>Contains a snapshot of the Advanced Color-related information of a monitor or display driver.</summary>
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class AdvancedColorInfo : IAdvancedColorInfo
  {
    /// <summary>Gets the AdvancedColorKind which is currently being set on the display.</summary>
    /// <returns>The AdvancedColorKind which is currently being set on the display.</returns>
    public extern AdvancedColorKind CurrentAdvancedColorKind { [MethodImpl] get; }

    /// <summary>Gets the native Red color primary for the display.</summary>
    /// <returns>The native Red color primary for the display.</returns>
    public extern Point RedPrimary { [MethodImpl] get; }

    /// <summary>Gets the native Green color primary for the display.</summary>
    /// <returns>The native Green color primary for the display.</returns>
    public extern Point GreenPrimary { [MethodImpl] get; }

    /// <summary>Gets the native Blue color primary for the display.</summary>
    /// <returns>The native Blue color primary for the display.</returns>
    public extern Point BluePrimary { [MethodImpl] get; }

    /// <summary>Gets the native white point for the display.</summary>
    /// <returns>The native white point for the display.</returns>
    public extern Point WhitePoint { [MethodImpl] get; }

    /// <summary>Gets the maximum peak luminance of the display in nits, which is usually valid for a small part of the display.</summary>
    /// <returns>The maximum peak luminance of the display in nits.</returns>
    public extern float MaxLuminanceInNits { [MethodImpl] get; }

    /// <summary>Get the minimum luminance of the display in nits.</summary>
    /// <returns>The minimum luminance of the display in nits.</returns>
    public extern float MinLuminanceInNits { [MethodImpl] get; }

    /// <summary>Gets the maximum frame average luminance of the display which can be achieved on the whole display.</summary>
    /// <returns>The maximum frame average luminance of the display which can be achieved on the whole display.</returns>
    public extern float MaxAverageFullFrameLuminanceInNits { [MethodImpl] get; }

    /// <summary>Get the luminance value, in nits, which is currently being used by the operating system for all the SDR content on this display.</summary>
    /// <returns>The luminance value, in nits.</returns>
    public extern float SdrWhiteLevelInNits { [MethodImpl] get; }

    /// <summary>Returns a boolean value that describes whether the specified HDR metadata format is supported by the display in its current state.</summary>
    /// <param name="format">The HDR metadata format to check.</param>
    /// <returns>**True** if the format is supported; otherwise, **false**.</returns>
    [MethodImpl]
    public extern bool IsHdrMetadataFormatCurrentlySupported(HdrMetadataFormat format);

    /// <summary>Returns a boolean value that describes if the specified Advanced Color kind value is inherently supported by the monitor or display driver.</summary>
    /// <param name="kind">The Advanced Color kind to check.</param>
    /// <returns>**True** if the specified Advanced Color kind is supported; otherwise, **false**.</returns>
    [MethodImpl]
    public extern bool IsAdvancedColorKindAvailable(AdvancedColorKind kind);
  }
}
