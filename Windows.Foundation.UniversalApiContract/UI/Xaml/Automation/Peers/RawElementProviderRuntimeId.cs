// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Peers.RawElementProviderRuntimeId
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Automation.Peers
{
  /// <summary>Represents the runtime ID for an element.</summary>
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public struct RawElementProviderRuntimeId
  {
    /// <summary>The first part of the identifier.</summary>
    public uint Part1;
    /// <summary>The second part of the identifier.</summary>
    public uint Part2;
  }
}
