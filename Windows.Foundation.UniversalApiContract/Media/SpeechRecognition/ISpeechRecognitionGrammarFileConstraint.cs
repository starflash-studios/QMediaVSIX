// Decompiled with JetBrains decompiler
// Type: Windows.Media.SpeechRecognition.ISpeechRecognitionGrammarFileConstraint
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage;

namespace Windows.Media.SpeechRecognition
{
  [ExclusiveTo(typeof (SpeechRecognitionGrammarFileConstraint))]
  [Guid(3036879503, 34250, 20388, 177, 26, 71, 79, 196, 27, 56, 53)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ISpeechRecognitionGrammarFileConstraint : ISpeechRecognitionConstraint
  {
    StorageFile GrammarFile { get; }
  }
}
