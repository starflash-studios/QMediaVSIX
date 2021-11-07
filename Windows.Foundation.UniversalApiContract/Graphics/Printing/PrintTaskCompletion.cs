// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Printing.PrintTaskCompletion
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Printing
{
  /// <summary>Specifies the completion status of a print task.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum PrintTaskCompletion
  {
    /// <summary>An abandoned print task.</summary>
    Abandoned,
    /// <summary>A canceled print task.</summary>
    Canceled,
    /// <summary>A failed print task.</summary>
    Failed,
    /// <summary>A submitted print task.</summary>
    Submitted,
  }
}
