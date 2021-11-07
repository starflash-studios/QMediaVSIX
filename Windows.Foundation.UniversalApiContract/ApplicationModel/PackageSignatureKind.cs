// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.PackageSignatureKind
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel
{
  /// <summary>Specifies the ways that an app package may be signed.</summary>
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  public enum PackageSignatureKind
  {
    /// <summary>Not signed.</summary>
    None,
    /// <summary>Deployed in your development environment. The package is signed with a private certificate.</summary>
    Developer,
    /// <summary>Signed using a certificate used in enterprises.</summary>
    Enterprise,
    /// <summary>Signed by the Windows Store.</summary>
    Store,
    /// <summary>Built-in system app.</summary>
    System,
  }
}
