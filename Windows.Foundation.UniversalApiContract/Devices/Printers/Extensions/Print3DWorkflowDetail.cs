// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Printers.Extensions.Print3DWorkflowDetail
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Printers.Extensions
{
  /// <summary>Specifies the types of errors that may be encountered by the Print3DWorkflow class.</summary>
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  public enum Print3DWorkflowDetail
  {
    /// <summary>No known error has been encountered.</summary>
    Unknown,
    /// <summary>The 3D model exceeds the print bed.</summary>
    ModelExceedsPrintBed,
    /// <summary>The upload failed.</summary>
    UploadFailed,
    /// <summary>An invalid printing material has been selected.</summary>
    InvalidMaterialSelection,
    /// <summary>The 3D model is not valid.</summary>
    InvalidModel,
    /// <summary>The 3D model does not have manifold edges.</summary>
    ModelNotManifold,
    /// <summary>The print ticket is not valid.</summary>
    InvalidPrintTicket,
  }
}
