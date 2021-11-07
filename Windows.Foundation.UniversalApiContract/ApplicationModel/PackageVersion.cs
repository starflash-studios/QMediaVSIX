// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.PackageVersion
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel
{
  /// <summary>Represents the package version info.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public struct PackageVersion
  {
    /// <summary>The major version number of the package.</summary>
    public ushort Major;
    /// <summary>The minor version number of the package.</summary>
    public ushort Minor;
    /// <summary>The build version number of the package.</summary>
    public ushort Build;
    /// <summary>The revision version number of the package.</summary>
    public ushort Revision;
  }
}
