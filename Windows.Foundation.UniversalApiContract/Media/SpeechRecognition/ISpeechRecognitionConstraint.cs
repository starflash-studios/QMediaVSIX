// Decompiled with JetBrains decompiler
// Type: Windows.Media.SpeechRecognition.ISpeechRecognitionConstraint
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.SpeechRecognition
{
  /// <summary>Represents a constraint for a SpeechRecognizer object.</summary>
  [Guid(2041321000, 19816, 17348, 137, 17, 64, 220, 65, 1, 181, 91)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public interface ISpeechRecognitionConstraint
  {
    /// <summary>Gets or sets whether the constraint can be used by the SpeechRecognizer object to perform recognition.</summary>
    /// <returns>True if a speech recognizer can perform recognition using the constraint; otherwise false.</returns>
    bool IsEnabled { get; set; }

    /// <summary>Gets or sets a tag that can be useful for identifying the constraint.</summary>
    /// <returns>A string representing the tag.</returns>
    string Tag { get; set; }

    /// <summary>Gets the type of the constraint.</summary>
    /// <returns>An enumeration that indicates the type of the constraint.</returns>
    SpeechRecognitionConstraintType Type { get; }

    /// <summary>Gets or sets the weighted value of the constraint.</summary>
    /// <returns>An enumeration that indicates the weighted value of the constraint.</returns>
    SpeechRecognitionConstraintProbability Probability { get; set; }
  }
}
