// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ContentLinkChangeKind
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  /// <summary>Defines constants that specify what kind of change is being made to a ContentLink.</summary>
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  public enum ContentLinkChangeKind
  {
    /// <summary>The content link is being added.</summary>
    Inserted,
    /// <summary>The content link is being removed.</summary>
    Removed,
    /// <summary>The content link is being changed.</summary>
    Edited,
  }
}
