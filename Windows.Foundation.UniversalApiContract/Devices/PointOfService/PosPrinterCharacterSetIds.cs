// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.PosPrinterCharacterSetIds
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.PointOfService
{
  /// <summary>Represents the set of identifiers for the character sets that a point-of-service printer can use.</summary>
  [DualApiPartition(version = 167772160)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (IPosPrinterCharacterSetIdsStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  public static class PosPrinterCharacterSetIds
  {
    /// <summary>Gets the identifier for the UTF16LE character set.</summary>
    /// <returns>The identifier for the UTF16LE character set.</returns>
    public static extern uint Utf16LE { [MethodImpl] get; }

    /// <summary>Gets the identifier for the ASCII character set.</summary>
    /// <returns>The identifier for the ASCII character set.</returns>
    public static extern uint Ascii { [MethodImpl] get; }

    /// <summary>Gets the identifier for the ANSI character set.</summary>
    /// <returns>The identifier for the ANSI character set.</returns>
    public static extern uint Ansi { [MethodImpl] get; }
  }
}
