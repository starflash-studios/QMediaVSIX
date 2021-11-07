// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Imaging.BitmapBuffer
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Imaging
{
  /// <summary>Represents the pixel data buffer of a bitmap.</summary>
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 167772160)]
  [GCPressure(amount = GCPressureAmount.High)]
  public sealed class BitmapBuffer : IBitmapBuffer, IMemoryBuffer, IClosable
  {
    /// <summary>Gets the number of bit planes in the bitmap buffer.</summary>
    /// <returns>The number of bit planes in the bitmap buffer.</returns>
    [MethodImpl]
    public extern int GetPlaneCount();

    /// <summary>Gets a BitmapPlaneDescription object that describes the size, offset, and stride of the bitmap data in the bit plane with the specified index.</summary>
    /// <param name="index">The index of the bit plane for which the description is retrieved.</param>
    /// <returns>The bit plane description.</returns>
    [MethodImpl]
    public extern BitmapPlaneDescription GetPlaneDescription(int index);

    /// <summary>Creates a reference to the underlying memory buffer.</summary>
    /// <returns>A reference to the underlying memory buffer.</returns>
    [MethodImpl]
    public extern IMemoryBufferReference CreateReference();

    [MethodImpl]
    public extern void Close();
  }
}
