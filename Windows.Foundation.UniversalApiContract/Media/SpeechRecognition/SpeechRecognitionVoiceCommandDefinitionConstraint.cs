// Decompiled with JetBrains decompiler
// Type: Windows.Media.SpeechRecognition.SpeechRecognitionVoiceCommandDefinitionConstraint
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.SpeechRecognition
{
  /// <summary>A constraint for a SpeechRecognizer object based on a  file.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class SpeechRecognitionVoiceCommandDefinitionConstraint : 
    ISpeechRecognitionVoiceCommandDefinitionConstraint,
    ISpeechRecognitionConstraint
  {
    /// <summary>Gets or sets whether the constraint can be used by the SpeechRecognizer object to perform recognition.</summary>
    /// <returns>if a speech recognizer can perform recognition using the constraint; otherwise .</returns>
    public extern bool IsEnabled { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a tag that can be useful for identifying the constraint.</summary>
    /// <returns>A string representing the tag.</returns>
    public extern string Tag { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets the type of the constraint.</summary>
    /// <returns>An enumeration that indicates the type of the constraint.</returns>
    public extern SpeechRecognitionConstraintType Type { [MethodImpl] get; }

    /// <summary>Gets or sets the weighted value of the constraint.</summary>
    /// <returns>An enumeration that indicates the weighted value of the constraint.</returns>
    public extern SpeechRecognitionConstraintProbability Probability { [MethodImpl] get; [MethodImpl] set; }
  }
}
