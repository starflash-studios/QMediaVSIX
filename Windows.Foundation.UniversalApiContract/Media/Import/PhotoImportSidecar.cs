// Decompiled with JetBrains decompiler
// Type: Windows.Media.Import.PhotoImportSidecar
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Import
{
  /// <summary>Represents a sidecar file or a sibling file to a PhotoImportItem.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 167772160)]
  public sealed class PhotoImportSidecar : IPhotoImportSidecar
  {
    /// <summary>Gets the name of the sidecar or sibling file.</summary>
    /// <returns>The name of the sidecar or sibling file.</returns>
    public extern string Name { [MethodImpl] get; }

    /// <summary>Gets the size of the sidecar or sibling file, in bytes.</summary>
    /// <returns>The size of the sidecar or sibling file, in bytes.</returns>
    public extern ulong SizeInBytes { [MethodImpl] get; }

    /// <summary>Gets the date of the sidecar or sibling file.</summary>
    /// <returns>The date of the sidecar or sibling file.</returns>
    public extern DateTime Date { [MethodImpl] get; }
  }
}
