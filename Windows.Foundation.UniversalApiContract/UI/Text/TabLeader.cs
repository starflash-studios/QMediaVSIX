// Decompiled with JetBrains decompiler
// Type: Windows.UI.Text.TabLeader
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Text
{
  /// <summary>The character that is used to fill the space taken by a tab character.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum TabLeader
  {
    /// <summary>Spaces are used. This is the default.</summary>
    Spaces,
    /// <summary>Dots are used.</summary>
    Dots,
    /// <summary>A dashed line is used.</summary>
    Dashes,
    /// <summary>A solid line is used.</summary>
    Lines,
    /// <summary>A thick line is used.</summary>
    ThickLines,
    /// <summary>An equal sign is used.</summary>
    Equals,
  }
}
