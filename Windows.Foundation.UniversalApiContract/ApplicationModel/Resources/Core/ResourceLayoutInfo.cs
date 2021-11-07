// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Resources.Core.ResourceLayoutInfo
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Resources.Core
{
  /// <summary>Structure that determines version and counts of resources returned for the app package.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public struct ResourceLayoutInfo
  {
    /// <summary>Major version of resources to be returned.</summary>
    public uint MajorVersion;
    /// <summary>Minor version of resources to be returned.</summary>
    public uint MinorVersion;
    /// <summary>Number of resource subtrees to be returned.</summary>
    public uint ResourceSubtreeCount;
    /// <summary>Number of named resources to be returned.</summary>
    public uint NamedResourceCount;
    /// <summary>Framework-generated checksum.</summary>
    public int Checksum;
  }
}
