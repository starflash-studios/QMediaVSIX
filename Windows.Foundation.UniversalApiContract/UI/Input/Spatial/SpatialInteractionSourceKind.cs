// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Spatial.SpatialInteractionSourceKind
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input.Spatial
{
  /// <summary>Specifies the kind of an interaction source.</summary>
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  public enum SpatialInteractionSourceKind
  {
    /// <summary>The interaction source is of a kind not known in this version of the API.</summary>
    Other,
    /// <summary>The interaction source is one of the user's hands.</summary>
    Hand,
    /// <summary>The interaction source is the user's speech, when speaking a system command such as "Select".</summary>
    Voice,
    /// <summary>The interaction source is a motion controller.</summary>
    Controller,
  }
}
