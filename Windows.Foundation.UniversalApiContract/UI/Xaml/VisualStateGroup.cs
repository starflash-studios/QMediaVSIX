// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.VisualStateGroup
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Markup;

namespace Windows.UI.Xaml
{
  /// <summary>Contains mutually exclusive VisualState objects and VisualTransition objects that are used to go from one state to another.</summary>
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContentProperty(Name = "States")]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class VisualStateGroup : DependencyObject, IVisualStateGroup
  {
    /// <summary>Initializes a new instance of the VisualStateGroup class.</summary>
    [MethodImpl]
    public extern VisualStateGroup();

    /// <summary>Gets the name of the VisualStateGroup.</summary>
    /// <returns>The name of the VisualStateGroup.</returns>
    public extern string Name { [MethodImpl] get; }

    /// <summary>Gets the collection of VisualTransition objects.</summary>
    /// <returns>The collection of VisualTransition objects.</returns>
    public extern IVector<VisualTransition> Transitions { [MethodImpl] get; }

    /// <summary>Gets the collection of mutually exclusive VisualState objects.</summary>
    /// <returns>The collection of mutually exclusive VisualState objects.</returns>
    public extern IVector<VisualState> States { [MethodImpl] get; }

    /// <summary>Gets the most recently set VisualState from a successful call to the GoToState method.</summary>
    /// <returns>The most recently set VisualState from a successful call to the GoToState method, or **null**.</returns>
    public extern VisualState CurrentState { [MethodImpl] get; }

    /// <summary>Occurs after a control changes into a different state.</summary>
    public extern event VisualStateChangedEventHandler CurrentStateChanged;

    /// <summary>Occurs when a control begins changing into a different state.</summary>
    public extern event VisualStateChangedEventHandler CurrentStateChanging;
  }
}
