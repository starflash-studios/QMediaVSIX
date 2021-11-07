// Decompiled with JetBrains decompiler
// Type: Windows.Media.Import.PhotoImportVideoSegment
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Media.Import
{
  /// <summary>Represents an imported video segment.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 167772160)]
  public sealed class PhotoImportVideoSegment : IPhotoImportVideoSegment
  {
    /// <summary>Gets the name of the imported video segment.</summary>
    /// <returns>The name of the imported video segment.</returns>
    public extern string Name { [MethodImpl] get; }

    /// <summary>Gets the size of the imported video segment, in bytes.</summary>
    /// <returns>The size of the imported video segment, in bytes.</returns>
    public extern ulong SizeInBytes { [MethodImpl] get; }

    /// <summary>Gets the date of the imported video segment.</summary>
    /// <returns>The date of the imported video segment.</returns>
    public extern DateTime Date { [MethodImpl] get; }

    /// <summary>Gets the sibling file associated with the imported video segment.</summary>
    /// <returns>The sibling file associated with the imported video segment.</returns>
    public extern PhotoImportSidecar Sibling { [MethodImpl] get; }

    /// <summary>Gets the sidecar file associated with the imported video segment.</summary>
    /// <returns>The sidecar file associated with the imported video segment.</returns>
    public extern IVectorView<PhotoImportSidecar> Sidecars { [MethodImpl] get; }
  }
}
