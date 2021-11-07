// Decompiled with JetBrains decompiler
// Type: Windows.Media.SpeechRecognition.ISpeechRecognitionTopicConstraintFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.SpeechRecognition
{
  [ExclusiveTo(typeof (SpeechRecognitionTopicConstraint))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1852335071, 60421, 18391, 165, 223, 86, 163, 67, 30, 88, 210)]
  internal interface ISpeechRecognitionTopicConstraintFactory
  {
    SpeechRecognitionTopicConstraint Create(
      SpeechRecognitionScenario scenario,
      string topicHint);

    SpeechRecognitionTopicConstraint CreateWithTag(
      SpeechRecognitionScenario scenario,
      string topicHint,
      string tag);
  }
}
