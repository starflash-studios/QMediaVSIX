﻿// Decompiled with JetBrains decompiler
// Type: Windows.Management.Deployment.DeploymentProgress
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Management.Deployment
{
  /// <summary>Contains progress information for the deployment request.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public struct DeploymentProgress
  {
    /// <summary>The progress state of the deployment request.</summary>
    public DeploymentProgressState state;
    /// <summary>The progress percentage of the deployment request.</summary>
    public uint percentage;
  }
}