// Decompiled with JetBrains decompiler
// Type: Windows.Storage.SystemPhotoProperties
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Storage
{
  /// <summary>A helper object that provides indexing names for Windows photo file properties.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class SystemPhotoProperties : ISystemPhotoProperties
  {
    /// <summary>Gets the name of the System.Photo.CameraManufacturer property (one of the Windows photo file properties.</summary>
    /// <returns>The name of the System.Photo.CameraManufacturer file property.</returns>
    public extern string CameraManufacturer { [MethodImpl] get; }

    /// <summary>Gets the name of the System.Photo.CameraModel property (one of the Windows photo file properties.</summary>
    /// <returns>The name of the System.Photo.CameraModel file property.</returns>
    public extern string CameraModel { [MethodImpl] get; }

    /// <summary>Gets the name of the System.Photo.DateTaken property (one of the Windows photo file properties.</summary>
    /// <returns>The name of the System.Photo.DateTaken file property.</returns>
    public extern string DateTaken { [MethodImpl] get; }

    /// <summary>Gets the name of the System.Photo.Orientation property (one of the Windows photo file properties.</summary>
    /// <returns>The name of the System.Photo.Orientation file property.</returns>
    public extern string Orientation { [MethodImpl] get; }

    /// <summary>Gets the name of the System.Photo.PeopleNames property (one of the Windows photo file properties.</summary>
    /// <returns>The name of the System.Photo.PeopleNames file property.</returns>
    public extern string PeopleNames { [MethodImpl] get; }
  }
}
