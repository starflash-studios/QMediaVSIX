// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Holographic.HolographicSpaceUserPresence
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Holographic
{
  /// <summary>Represents whether the user is present within the headset to view and interact with a particular HolographicSpace.</summary>
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  public enum HolographicSpaceUserPresence
  {
    /// <summary>This HolographicSpace is not visible in the headset or the user is not wearing the headset.</summary>
    Absent,
    /// <summary>This HolographicSpace is visible in the headset and the user is wearing the headset, but a modal dialog is taking all input from the app.</summary>
    PresentPassive,
    /// <summary>This HolographicSpace is visible in the headset, the user is wearing the headset, and input is being routed to the app.</summary>
    PresentActive,
  }
}
