// Decompiled with JetBrains decompiler
// Type: Windows.Media.SpeechRecognition.SpeechRecognitionListConstraint
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Media.SpeechRecognition
{
  /// <summary>A custom grammar constraint based on a list of words or phrases that can be recognized by the SpeechRecognizer object. When initialized, this object is added to the Constraints collection.</summary>
  [Activatable(typeof (ISpeechRecognitionListConstraintFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [DualApiPartition(version = 167772160)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class SpeechRecognitionListConstraint : 
    ISpeechRecognitionListConstraint,
    ISpeechRecognitionConstraint
  {
    [MethodImpl]
    public extern SpeechRecognitionListConstraint(IIterable<string> commands);

    [MethodImpl]
    public extern SpeechRecognitionListConstraint(IIterable<string> commands, string tag);

    /// <summary>Gets the array of words or phrases that make up the constraint.</summary>
    /// <returns>A string array of words or phrases that make up the constraint.</returns>
    public extern IVector<string> Commands { [MethodImpl] get; }

    /// <summary>Gets or sets whether the constraint can be used by the speech recognizer to perform recognition.</summary>
    /// <returns>if a speech recognizer can perform recognition using the constraint; otherwise .</returns>
    public extern bool IsEnabled { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a tag that can be useful for identifying the constraint.</summary>
    /// <returns>A string representing the tag.</returns>
    public extern string Tag { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets the type of the constraint.</summary>
    /// <returns>An enumeration that indicates the type of the constraint. Always returns List for SpeechRecognitionListConstraint.</returns>
    public extern SpeechRecognitionConstraintType Type { [MethodImpl] get; }

    /// <summary>Gets or sets the weighted value of the constraint.</summary>
    /// <returns>An enumeration that indicates the weighted value of the constraint.</returns>
    public extern SpeechRecognitionConstraintProbability Probability { [MethodImpl] get; [MethodImpl] set; }
  }
}
