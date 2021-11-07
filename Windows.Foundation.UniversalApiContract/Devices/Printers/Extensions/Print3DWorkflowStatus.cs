// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Printers.Extensions.Print3DWorkflowStatus
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Printers.Extensions
{
  /// <summary>Specifies the status of the Print3DWorkflow class.</summary>
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  public enum Print3DWorkflowStatus
  {
    /// <summary>The printing experience has been abandoned.</summary>
    Abandoned,
    /// <summary>The printing experience has been canceled.</summary>
    Canceled,
    /// <summary>The print request failed.</summary>
    Failed,
    /// <summary>The object is undergoing slicing in preparation for printing.</summary>
    Slicing,
    /// <summary>The print request has been submitted.</summary>
    Submitted,
  }
}
