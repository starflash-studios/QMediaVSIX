// Decompiled with JetBrains decompiler
// Type: Windows.System.ProtocolForResultsOperation
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.System
{
  /// <summary>Represents the result to the application that launched the current application for results.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class ProtocolForResultsOperation : IProtocolForResultsOperation
  {
    /// <summary>Indicates that the application activated for results is ready to return to the application that launched it for results.</summary>
    /// <param name="data">The data to return to the application that activated this app. </param>
    [MethodImpl]
    public extern void ReportCompleted(ValueSet data);
  }
}
