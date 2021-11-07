// Decompiled with JetBrains decompiler
// Type: Windows.Media.SpeechRecognition.SpeechRecognitionCompilationResult
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.SpeechRecognition
{
  /// <summary>The result of compiling the constraints set for a SpeechRecognizer object.</summary>
  [DualApiPartition(version = 167772160)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class SpeechRecognitionCompilationResult : ISpeechRecognitionCompilationResult
  {
    /// <summary>Gets the result state (SpeechRecognitionResultStatus ) from the compiling of grammar constraints.</summary>
    /// <returns>The status of the result.</returns>
    public extern SpeechRecognitionResultStatus Status { [MethodImpl] get; }
  }
}
