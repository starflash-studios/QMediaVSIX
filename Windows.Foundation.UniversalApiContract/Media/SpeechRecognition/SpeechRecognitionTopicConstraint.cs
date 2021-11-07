// Decompiled with JetBrains decompiler
// Type: Windows.Media.SpeechRecognition.SpeechRecognitionTopicConstraint
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.SpeechRecognition
{
  /// <summary>A pre-defined grammar constraint (specifed by SpeechRecognitionScenario ) provided through a web service.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(typeof (ISpeechRecognitionTopicConstraintFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 167772160)]
  public sealed class SpeechRecognitionTopicConstraint : 
    ISpeechRecognitionTopicConstraint,
    ISpeechRecognitionConstraint
  {
    /// <summary>Creates an instance of the SpeechRecognitionTopicConstraint class by using a pre-defined scenario type and context.</summary>
    /// <param name="scenario">A predefined scenario type.</param>
    /// <param name="topicHint">A subject, or context hint, used to optimize recognition.</param>
    [MethodImpl]
    public extern SpeechRecognitionTopicConstraint(
      SpeechRecognitionScenario scenario,
      string topicHint);

    /// <summary>Creates an instance of the SpeechRecognitionTopicConstraint class by using a pre-defined scenario type, context, and an identifier.</summary>
    /// <param name="scenario">A predefined scenario type.</param>
    /// <param name="topicHint">A subject, or context hint, used to optimize recognition.</param>
    /// <param name="tag">Identifier for the constraint.</param>
    [MethodImpl]
    public extern SpeechRecognitionTopicConstraint(
      SpeechRecognitionScenario scenario,
      string topicHint,
      string tag);

    /// <summary>Gets the predefined scenario type for the constraint.</summary>
    /// <returns>The predefined scenario type for the constraint.</returns>
    public extern SpeechRecognitionScenario Scenario { [MethodImpl] get; }

    /// <summary>Gets the topic hint for the constraint.</summary>
    /// <returns>The topic hint for the constraint.</returns>
    public extern string TopicHint { [MethodImpl] get; }

    /// <summary>Gets or sets whether the constraint can be used by the SpeechRecognizer object to perform recognition.</summary>
    /// <returns>if a speech recognizer can perform recognition using the constraint; otherwise .</returns>
    public extern bool IsEnabled { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a tag that can be useful for identifying the constraint.</summary>
    /// <returns>A string representing the tag.</returns>
    public extern string Tag { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets the type of the constraint.</summary>
    /// <returns>An enumeration that indicates the type of the constraint. Always returns Topic for SpeechRecognitionTopicConstraint.</returns>
    public extern SpeechRecognitionConstraintType Type { [MethodImpl] get; }

    /// <summary>Gets or sets the weighted value of the constraint.</summary>
    /// <returns>An enumeration that indicates the weighted value of the constraint.</returns>
    public extern SpeechRecognitionConstraintProbability Probability { [MethodImpl] get; [MethodImpl] set; }
  }
}
