// Decompiled with JetBrains decompiler
// Type: Windows.Management.Deployment.DeploymentResult
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Management.Deployment
{
  /// <summary>Provides the result of a deployment request.</summary>
  [DualApiPartition(version = 1)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class DeploymentResult : IDeploymentResult, IDeploymentResult2
  {
    /// <summary>Gets extended error text for the error if the deployment operation is not successful.</summary>
    /// <returns>The extended error text.</returns>
    public extern string ErrorText { [MethodImpl] get; }

    /// <summary>Gets the activity identifier used to look up an event in Windows Event Viewer. Gets the activity identifier used to look up an event. All events of a deployment operation are logged with the same **activityId**.</summary>
    /// <returns>The activity identifier.</returns>
    public extern Guid ActivityId { [MethodImpl] get; }

    /// <summary>The extended error code can be used to distinguish a specific error condition which needs to be handled differently from the general error indicated by the return code. The extended error code may provide a more specific reason for the failure that caused the general error. Also, it usually corresponds directly to the specific message in the ErrorText.</summary>
    /// <returns>The error code.</returns>
    public extern HResult ExtendedErrorCode { [MethodImpl] get; }

    /// <summary>Describes whether or not the package is fully registered and ready to use.</summary>
    /// <returns>true if the package is registered; otherwise, false.</returns>
    public extern bool IsRegistered { [MethodImpl] get; }
  }
}
