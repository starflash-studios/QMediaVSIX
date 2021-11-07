// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.StretchDirection
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  /// <summary>Defines constants that specify the direction that content is scaled.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  public enum StretchDirection
  {
    /// <summary>The content scales upward only when it is smaller than the parent. If the content is larger, no scaling downward is performed.</summary>
    UpOnly,
    /// <summary>The content scales downward only when it is larger than the parent. If the content is smaller, no scaling upward is performed.</summary>
    DownOnly,
    /// <summary>The content stretches to fit the parent according to the Stretch property.</summary>
    Both,
  }
}
