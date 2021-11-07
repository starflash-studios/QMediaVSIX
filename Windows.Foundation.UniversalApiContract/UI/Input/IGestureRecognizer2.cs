// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.IGestureRecognizer2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input
{
  [ContractVersion(typeof (UniversalApiContract), 655360)]
  [ExclusiveTo(typeof (GestureRecognizer))]
  [Guid(3594914175, 28407, 22342, 139, 168, 143, 242, 32, 110, 111, 59)]
  internal interface IGestureRecognizer2
  {
    uint TapMinContactCount { get; set; }

    uint TapMaxContactCount { get; set; }

    uint HoldMinContactCount { get; set; }

    uint HoldMaxContactCount { get; set; }

    float HoldRadius { get; set; }

    TimeSpan HoldStartDelay { get; set; }

    uint TranslationMinContactCount { get; set; }

    uint TranslationMaxContactCount { get; set; }
  }
}
