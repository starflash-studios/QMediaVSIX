// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Connectivity.TriStates
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Connectivity
{
  /// <summary>Used with the NetworkUsageStates structure to define the desired roaming state and shared state of a network connection.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum TriStates
  {
    /// <summary>Used when the corresponding state should not be used as a filter, for example, both yes and no.</summary>
    DoNotCare,
    /// <summary>The corresponding state is not set.</summary>
    No,
    /// <summary>The corresponding state is set.</summary>
    Yes,
  }
}
