// Decompiled with JetBrains decompiler
// Type: Windows.UI.ViewManagement.HandPreference
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.ViewManagement
{
  /// <summary>Defines the set of directional preferences for the user interface presented by the app view.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum HandPreference
  {
    /// <summary>The preferred layout is for left-directional users.</summary>
    LeftHanded,
    /// <summary>The preferred layout is for right-directional users.</summary>
    RightHanded,
  }
}
