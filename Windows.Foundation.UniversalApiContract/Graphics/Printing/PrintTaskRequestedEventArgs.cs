// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Printing.PrintTaskRequestedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Printing
{
  /// <summary>Event arguments associated with the PrintTaskRequest.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class PrintTaskRequestedEventArgs : IPrintTaskRequestedEventArgs
  {
    /// <summary>Gets the PrintTaskRequest object for a print task.</summary>
    /// <returns>The PrintTaskRequest object for a print task.</returns>
    public extern PrintTaskRequest Request { [MethodImpl] get; }
  }
}
