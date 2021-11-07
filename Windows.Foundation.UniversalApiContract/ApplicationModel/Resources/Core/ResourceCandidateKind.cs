// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Resources.Core.ResourceCandidateKind
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Resources.Core
{
  /// <summary>Defines values that represent the type of resource that is encapsulated in a ResourceCandidate.</summary>
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  public enum ResourceCandidateKind
  {
    /// <summary>The resource is a string.</summary>
    String,
    /// <summary>The resource is a file.</summary>
    File,
    /// <summary>The resource is embedded data in some containing resource file (such as a .resw file).</summary>
    EmbeddedData,
  }
}
