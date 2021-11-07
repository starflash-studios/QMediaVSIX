// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Background.BackgroundWorkCostValue
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Background
{
  /// <summary>Indicates the current cost of doing background work. Used as a hint to background tasks about how much work they can do.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum BackgroundWorkCostValue
  {
    /// <summary>Background resource usage is low. The background task can do work.</summary>
    Low,
    /// <summary>Background resources are in use, but the background task can do some work.</summary>
    Medium,
    /// <summary>Background resources are under heavy use and the background task should not do any work.</summary>
    High,
  }
}
