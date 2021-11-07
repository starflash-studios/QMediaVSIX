// Decompiled with JetBrains decompiler
// Type: Windows.Media.SpeechRecognition.ISpeechRecognitionListConstraintFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Media.SpeechRecognition
{
  [ExclusiveTo(typeof (SpeechRecognitionListConstraint))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1089719751, 22058, 17002, 159, 59, 59, 78, 40, 43, 225, 213)]
  internal interface ISpeechRecognitionListConstraintFactory
  {
    SpeechRecognitionListConstraint Create(IIterable<string> commands);

    SpeechRecognitionListConstraint CreateWithTag(
      IIterable<string> commands,
      string tag);
  }
}
