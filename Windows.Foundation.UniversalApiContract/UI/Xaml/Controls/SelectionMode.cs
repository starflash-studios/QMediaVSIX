﻿// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.SelectionMode
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  /// <summary>Defines constants that specify the selection behavior for a ListBox.</summary>
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum SelectionMode
  {
    /// <summary>The user can select only one item at a time.</summary>
    Single,
    /// <summary>The user can select multiple items without entering a special mode.</summary>
    Multiple,
    /// <summary>The user can select multiple items by entering a special mode, for example when depressing a modifier key.</summary>
    Extended,
  }
}