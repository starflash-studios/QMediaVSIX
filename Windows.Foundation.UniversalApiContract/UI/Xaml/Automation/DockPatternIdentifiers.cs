﻿// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.DockPatternIdentifiers
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Automation
{
  /// <summary>Contains values used as identifiers by IDockProvider.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [Static(typeof (IDockPatternIdentifiersStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class DockPatternIdentifiers : IDockPatternIdentifiers
  {
    /// <summary>Identifies the DockPosition automation property.</summary>
    /// <returns>The automation property identifier.</returns>
    public static extern AutomationProperty DockPositionProperty { [MethodImpl] get; }
  }
}