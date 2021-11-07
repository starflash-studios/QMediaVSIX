// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.PackageId
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.System;

namespace Windows.ApplicationModel
{
  /// <summary>Provides package identification info, such as name, version, and publisher.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 100794368)]
  public sealed class PackageId : IPackageId, IPackageIdWithMetadata
  {
    /// <summary>Gets the name of the package.</summary>
    /// <returns>The package name.</returns>
    public extern string Name { [MethodImpl] get; }

    /// <summary>Gets the package version info.</summary>
    /// <returns>The package version information.</returns>
    public extern PackageVersion Version { [MethodImpl] get; }

    /// <summary>Gets the processor architecture for which the package was created.</summary>
    /// <returns>The processor architecture.</returns>
    public extern ProcessorArchitecture Architecture { [MethodImpl] get; }

    /// <summary>Gets the resource ID of the package.</summary>
    /// <returns>The resource ID. If there is no resource ID for the package, this property is null.</returns>
    public extern string ResourceId { [MethodImpl] get; }

    /// <summary>Gets the publisher of the package.</summary>
    /// <returns>The publisher.</returns>
    public extern string Publisher { [MethodImpl] get; }

    /// <summary>Gets the publisher ID of the package.</summary>
    /// <returns>The publisher ID.</returns>
    public extern string PublisherId { [MethodImpl] get; }

    /// <summary>Gets the full name of the package.</summary>
    /// <returns>The full name.</returns>
    public extern string FullName { [MethodImpl] get; }

    /// <summary>Gets the family name of the package.</summary>
    /// <returns>The family name.</returns>
    public extern string FamilyName { [MethodImpl] get; }

    /// <summary>Windows Phone only. Gets the value of the ProductID attribute associated with this XAP application package.</summary>
    /// <returns>The value of the ProductID attribute associated with this XAP application package.</returns>
    public extern string ProductId { [MethodImpl] get; }

    /// <summary>Windows Phone only. Gets the value of the Author attribute for the specified application package.</summary>
    /// <returns>The value of the Author attribute for the specified application package.</returns>
    public extern string Author { [MethodImpl] get; }
  }
}
