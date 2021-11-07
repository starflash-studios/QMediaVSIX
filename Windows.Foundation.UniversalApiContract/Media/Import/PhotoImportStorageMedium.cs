// Decompiled with JetBrains decompiler
// Type: Windows.Media.Import.PhotoImportStorageMedium
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Import
{
  /// <summary>Represents a storage medium exposed by a photo import source device.</summary>
  [DualApiPartition(version = 167772160)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class PhotoImportStorageMedium : IPhotoImportStorageMedium
  {
    /// <summary>Gets the name of the storage medium.</summary>
    /// <returns>The name of the storage medium.</returns>
    public extern string Name { [MethodImpl] get; }

    /// <summary>Gets a description of the storage medium.</summary>
    /// <returns>A description of the storage medium.</returns>
    public extern string Description { [MethodImpl] get; }

    /// <summary>Gets the serial number of the storage medium.</summary>
    /// <returns>The serial number of the storage medium.</returns>
    public extern string SerialNumber { [MethodImpl] get; }

    /// <summary>Gets the type of the storage medium.</summary>
    /// <returns>The type of the storage medium.</returns>
    public extern PhotoImportStorageMediumType StorageMediumType { [MethodImpl] get; }

    /// <summary>Gets a value indicating the access modes supported by the storage medium.</summary>
    /// <returns>A value indicating the access modes supported by the storage medium.</returns>
    public extern PhotoImportAccessMode SupportedAccessMode { [MethodImpl] get; }

    /// <summary>Gets the capacity of the storage media, in bytes.</summary>
    /// <returns>The capacity of the storage media, in bytes.</returns>
    public extern ulong CapacityInBytes { [MethodImpl] get; }

    /// <summary>Gets the available space on the storage medium, in bytes.</summary>
    /// <returns>The available space on the storage medium, in bytes.</returns>
    public extern ulong AvailableSpaceInBytes { [MethodImpl] get; }

    /// <summary>Refreshes the information about the storage medium.</summary>
    [MethodImpl]
    public extern void Refresh();
  }
}
