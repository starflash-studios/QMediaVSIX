// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.EdgeGestureKind
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input
{
  /// <summary>Specifies the type of user input that triggered the edge gesture event.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum EdgeGestureKind
  {
    /// <summary>The user made a swipe gesture on a touch-enabled screen.</summary>
    Touch,
    /// <summary>The user entered the Win+Z key sequence on the keyboard.</summary>
    Keyboard,
    /// <summary>The user performed a right mouse click.</summary>
    Mouse,
  }
}
