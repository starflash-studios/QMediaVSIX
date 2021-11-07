// Decompiled with JetBrains decompiler
// Type: Windows.System.AppResourceGroupExecutionState
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System
{
  /// <summary>Describes the execution state of the resource group.</summary>
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  public enum AppResourceGroupExecutionState
  {
    /// <summary>The execution state is not known.</summary>
    Unknown,
    /// <summary>The resource group is part of an app that is currently running.</summary>
    Running,
    /// <summary>The resource group is part of an app that is entering the suspend state.</summary>
    Suspending,
    /// <summary>The resource group is part of an app that has been suspended.</summary>
    Suspended,
    /// <summary>The resource group is part of an app that is not running.</summary>
    NotRunning,
  }
}
