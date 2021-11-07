// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Printing.PrintTaskProgressingEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Printing
{
  /// <summary>Contains the event arguments for the PrintTask.Progressing event. This event is raised during the submitting phase of the PrintTask.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class PrintTaskProgressingEventArgs : IPrintTaskProgressingEventArgs
  {
    /// <summary>Gets the page count for a print task.</summary>
    /// <returns>The page count for a print task.</returns>
    public extern uint DocumentPageCount { [MethodImpl] get; }
  }
}
