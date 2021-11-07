// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.PosPrinterFontProperty
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.PointOfService
{
  /// <summary>Represents the property of a specific point-of-service printer font.</summary>
  [DualApiPartition(version = 1)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  public sealed class PosPrinterFontProperty : IPosPrinterFontProperty
  {
    /// <summary>Gets the typeface of the point-of-service printer font.</summary>
    /// <returns>The typeface of the point-of-service printer font.</returns>
    public extern string TypeFace { [MethodImpl] get; }

    /// <summary>Gets whether the point-of-service printer font is scalable to any size.</summary>
    /// <returns>True if the point-of-service printer font is scalable to any size; otherwise, false.</returns>
    public extern bool IsScalableToAnySize { [MethodImpl] get; }

    /// <summary>Gets the list of character sizes of the point-of-service printer font.</summary>
    /// <returns>The list of numeric value pairs for the character sizes of the point-of-service-printer font.</returns>
    public extern IVectorView<SizeUInt32> CharacterSizes { [MethodImpl] get; }
  }
}
