// Decompiled with JetBrains decompiler
// Type: Windows.Media.SpeechRecognition.SpeechRecognitionSemanticInterpretation
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Media.SpeechRecognition
{
  /// <summary>Represents the semantic properties of a recognized phrase in a Speech Recognition Grammar Specification (SRGS) grammar.</summary>
  [DualApiPartition(version = 167772160)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class SpeechRecognitionSemanticInterpretation : 
    ISpeechRecognitionSemanticInterpretation
  {
    /// <summary>Gets a dictionary of the semantic properties.</summary>
    /// <returns>A dictionary of the semantic properties.</returns>
    public extern IMapView<string, IVectorView<string>> Properties { [MethodImpl] get; }
  }
}
