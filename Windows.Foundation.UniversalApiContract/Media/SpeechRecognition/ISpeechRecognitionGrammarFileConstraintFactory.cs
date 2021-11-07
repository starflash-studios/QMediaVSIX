// Decompiled with JetBrains decompiler
// Type: Windows.Media.SpeechRecognition.ISpeechRecognitionGrammarFileConstraintFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage;

namespace Windows.Media.SpeechRecognition
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1034383595, 50297, 19495, 159, 25, 137, 151, 78, 243, 146, 209)]
  [ExclusiveTo(typeof (SpeechRecognitionGrammarFileConstraint))]
  internal interface ISpeechRecognitionGrammarFileConstraintFactory
  {
    SpeechRecognitionGrammarFileConstraint Create(
      StorageFile file);

    SpeechRecognitionGrammarFileConstraint CreateWithTag(
      StorageFile file,
      string tag);
  }
}
