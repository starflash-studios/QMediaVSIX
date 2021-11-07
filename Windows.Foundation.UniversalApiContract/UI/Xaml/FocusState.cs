// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.FocusState
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml
{
  /// <summary>Describes how an element obtained focus.</summary>
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum FocusState
  {
    /// <summary>Element is not currently focused.</summary>
    Unfocused,
    /// <summary>Element obtained focus through a pointer action.</summary>
    Pointer,
    /// <summary>Element obtained focus through a keyboard action, such as tab sequence traversal.</summary>
    Keyboard,
    /// <summary>Element obtained focus through a deliberate call to Focus or a related API.</summary>
    Programmatic,
  }
}
