// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Inking.IPenAndInkSettings
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input.Inking
{
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [ExclusiveTo(typeof (PenAndInkSettings))]
  [Guid(3157060495, 102, 17576, 187, 122, 184, 57, 179, 222, 184, 245)]
  internal interface IPenAndInkSettings
  {
    bool IsHandwritingDirectlyIntoTextFieldEnabled { get; }

    PenHandedness PenHandedness { get; }

    HandwritingLineHeight HandwritingLineHeight { get; }

    string FontFamilyName { get; }

    bool UserConsentsToHandwritingTelemetryCollection { get; }

    bool IsTouchHandwritingEnabled { get; }
  }
}
