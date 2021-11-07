// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.GroupStyleSelector
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  /// <summary>Enables custom group style selection logic as a function of the parent group and its level.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Composable(typeof (IGroupStyleSelectorFactory), CompositionType.Public, 65536, "Windows.Foundation.UniversalApiContract")]
  public class GroupStyleSelector : IGroupStyleSelector, IGroupStyleSelectorOverrides
  {
    /// <summary>Initializes a new instance of the GroupStyleSelector class.</summary>
    [MethodImpl]
    public extern GroupStyleSelector();

    /// <summary>Returns a specific GroupStyle for a given group and level.</summary>
    /// <param name="group">The group to return a GroupStyle for.</param>
    /// <param name="level">The level of nesting for the specified group.</param>
    /// <returns>TheGroupStyle to use when this GroupStyleSelector is invoked in an application.</returns>
    [MethodImpl]
    public extern GroupStyle SelectGroupStyle(object group, uint level);

    [MethodImpl]
    extern GroupStyle IGroupStyleSelectorOverrides.SelectGroupStyleCore(
      object group,
      uint level);
  }
}
